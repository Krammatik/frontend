namespace Infrastructure_Layer.Common.Models.Response.Authentication
{
    public class AuthenticationResponseModel
    {
        [JsonPropertyName("token")] public string Token { get; set; }
        [JsonPropertyName("message")] public string? Message { get; set; }
    }
}