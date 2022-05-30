using System.Security.Authentication;
using Application_Layer.Common.Models;
using Infrastructure_Layer.Common.Models.Request.Authentication;
using Infrastructure_Layer.Common.Models.Request.Register;
using Infrastructure_Layer.Common.Models.Request.Task;
using Infrastructure_Layer.Common.Models.Response.Authentication;
using Infrastructure_Layer.Common.Models.Response.Task;

namespace Infrastructure_Layer.Services
{
    public class KrammatikService : IKrammatikService
    {
        private RestClient client;

        public KrammatikService()
        {
            client = new RestClient(EndPoint.BaseUrl);
        }

        public async Task<string> AuthenticateByPasswordAsync(string username, string password,
            CancellationToken cancellationToken = default)
        {
            var request = new AuthenticationByPassword(username, password);
            var response = await client.ExecuteAsync<AuthenticationResponseModel>(request, cancellationToken);
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
            var response = await client.ExecuteAsync<List<KrammatikTaskResponse>>(request, cancellationToken);

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
            var response = await client.ExecuteAsync<AuthenticationResponseModel>(request, cancellationToken);

            throw new AuthenticationException(
                response.Data?.Message ?? $"received invalid status {response.StatusCode}");
        }
    }
}