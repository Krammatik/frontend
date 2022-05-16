

namespace Infrastructure_Layer.Common.Models.Swagger.Request.Authentication
{
    public class BaseLoginRequest:RestRequest
    {
        public BaseLoginRequest(string resource,Method method):base(resource,method)
        {
            // assignig Credtionals header to Request

            this.AddHeader("Content-Type", "application/json");
            this.AddHeader("Accept", "application/json");
        }
    }
}
