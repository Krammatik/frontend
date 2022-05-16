
namespace Infrastructure_Layer.Services
{
    public class SwaggerClient : ISwaggerClient
    {

        private RestClient client;

        public SwaggerClient()
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
