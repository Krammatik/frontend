using Infrastructure_Layer.Common.Models.Request.Authentication;

namespace Infrastructure_Layer.Common.Models.Request.User
{
   public class UserRequest: AuthenticatedRequest
    {
        public UserRequest(string token) : base(EndPoint.UserUrl, Method.Get, token)
        {
            this.AddHeader("Accept", "application/json");
            this.AddHeader("Content-Type", "application/json");
            this.AddHeader("Authorization", $"Bearer {token}");
        }
    }
}
