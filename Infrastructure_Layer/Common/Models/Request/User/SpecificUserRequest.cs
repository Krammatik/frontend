using Infrastructure_Layer.Common.Models.Request.Authentication;

namespace Infrastructure_Layer.Common.Models.Request.User;

public class SpecificUserRequest : AuthenticatedRequest
{
    public SpecificUserRequest(string token, string userId) : base(string.Format(EndPoint.SpecificUserUrl, userId),
        Method.Get, token)
    {
    }
}