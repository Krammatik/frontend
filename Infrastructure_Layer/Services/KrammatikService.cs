using System.Security.Authentication;
using Application_Layer.Common.Models;
using Infrastructure_Layer.Common.Models.Request.Authentication;
using Infrastructure_Layer.Common.Models.Request.Register;
using Infrastructure_Layer.Common.Models.Request.Task;
using Infrastructure_Layer.Common.Models.Request.User;
using Infrastructure_Layer.Common.Models.Response.Authentication;
using Infrastructure_Layer.Common.Models.Response.Task;
using Infrastructure_Layer.Common.Models.Response.User;

namespace Infrastructure_Layer.Services
{
    public class KrammatikService : IKrammatikService
    {
        private readonly RestClient _client;

        public KrammatikService()
        {
            _client = new RestClient(EndPoint.BaseUrl);
        }

        public async Task<string> AuthenticateByPasswordAsync(string username, string password,
            CancellationToken cancellationToken = default)
        {
            var request = new AuthenticationByPassword(username, password);
            var response = await _client.ExecuteAsync<AuthenticationResponseModel>(request, cancellationToken);
            if (response.IsSuccessful)
            {
                return response.Data?.Token ?? throw new AuthenticationException("no token provided");
            }

            throw new AuthenticationException(
                response.Data?.Message ?? $"received invalid status {response.StatusCode}");
        }

        public async Task<List<KrammatikTask>> GetTasks(string token, CancellationToken cancellationToken = default)
        {
            var request = new KrammatikTaskRequest(token);
            var response = await _client.ExecuteAsync<List<KrammatikTaskResponse>>(request, cancellationToken);

            var tasks = new List<KrammatikTask>();
            if (!response.IsSuccessful || response.Data == null)
            {
                return tasks;
            }

            tasks.AddRange(response.Data.Select(task => new KrammatikTask
            {
                Id = task.Id,
                Hint = task.Hint.ToAppMediaElement(),
                Score = task.Score,
                Solutions = task.Solutions.ConvertAll(s => s.ToAppSolution()),
                Title = task.Title,
                RecommendedTasks = task.Recommendations,
                AssignmentDescription = task.Value,
                GeneralDescription = task.Description.ToAppMediaElement()
            }));
            return tasks;
        }

        public async Task<string> SignupAsync(string username, string password,
            CancellationToken cancellationToken = default)
        {
            var request = new SignupRequest(username, password);
            var response = await _client.ExecuteAsync<AuthenticationResponseModel>(request, cancellationToken);

            return response.StatusCode.ToString();
        }

        public async Task<List<User>> GetAllUser(string token, CancellationToken cancellation = default)
        {
            var request = new UserRequest(token);
            var response = await _client.ExecuteAsync<List<UserResponseModel>>(request, cancellation);

            if (!response.IsSuccessful || response.Data == null)
            {
                return new List<User>();
            }

            return response.Data!.ConvertAll(u => new User
            {
                Id = u.Id,
                Groups = u.Groups,
                UserName = u.UserName
            });
        }

        public async Task<bool> IsLoginValid(string token, CancellationToken cancellation = default)
        {
            var request = new TokenValidationRequest(token);
            var response = await _client.ExecuteAsync(request, cancellation);

            return response.IsSuccessful;
        }

        public async Task<User> GetUser(string token, CancellationToken cancellation = default)
        {
            var request = new CurrentUserRequest(token);
            var response = await _client.ExecuteAsync<UserResponseModel>(request, cancellation);

            if (response.IsSuccessful)
            {
                return new User
                {
                    Id = response.Data!.Id,
                    Groups = response.Data!.Groups,
                    UserName = response.Data!.UserName
                };
            }

            throw new AuthenticationException($"received invalid status {response.StatusCode}");
        }

        public async Task<User?> GetSpecificUser(string token, string userId, CancellationToken cancellation = default)
        {
            var request = new SpecificUserRequest(token, userId);
            var response = await _client.ExecuteAsync<UserResponseModel>(request, cancellation);

            if (response.IsSuccessful)
            {
                return new User
                {
                    Id = response.Data!.Id,
                    Groups = response.Data!.Groups,
                    UserName = response.Data!.UserName
                };
            }

            return null;
        }
    }
}