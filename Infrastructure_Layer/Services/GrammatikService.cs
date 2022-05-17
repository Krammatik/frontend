
namespace Infrastructure_Layer.Services
{
    public class GrammatikService : IGrammatikService
    {

        private RestClient client;

        public GrammatikService()
        {
            this.client = new RestClient(EndPoint.endUrl);
            
        }
        
        public async Task AuthenticateByPasswordAsync(CancellationToken cancellationToken = default)
        {
            AuthenticationByPassword request = new AuthenticationByPassword();
            RestResponse<AuthentictionResponseModel> response =await client.ExecuteAsync<AuthentictionResponseModel>(request, cancellationToken);

        }

    }
}
