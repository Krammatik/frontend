namespace Infrastructure_Layer.Common.Models.Request.Authentication;

public class TokenValidationRequest : AuthenticatedRequest
{
    public TokenValidationRequest(string token) : base(EndPoint.ValidateTokenUrl, Method.Get, token)
    {
    }
}