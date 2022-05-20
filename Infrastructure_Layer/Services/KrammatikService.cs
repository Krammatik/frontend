using System.Security.Authentication;
using Infrastructure_Layer.Common.Models.Request.Authentication;
using Infrastructure_Layer.Common.Models.Response.Authentication;

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

            throw new AuthenticationException(response.Data?.Message ?? $"received invalid status {response.StatusCode}");
        }
    }
}