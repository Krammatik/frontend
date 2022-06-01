using Infrastructure_Layer.Common.Models.Request.Authentication;

namespace Infrastructure_Layer.Common.Models.Request.User;

public class CurrentUserRequest : AuthenticatedRequest
{
    public CurrentUserRequest(string token) : base(EndPoint.CurrentUserUrl, Method.Get, token)
    {
    }
}