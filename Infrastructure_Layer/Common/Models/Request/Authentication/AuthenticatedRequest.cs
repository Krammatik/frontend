namespace Infrastructure_Layer.Common.Models.Request.Authentication;

public class AuthenticatedRequest : BaseRequest
{
    protected AuthenticatedRequest(string resource, Method method, string token) : base(resource, method)
    {
        this.AddHeader("Authentication", $"Bearer {token}");
    }
}