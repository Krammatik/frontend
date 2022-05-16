

namespace Infrastructure_Layer.Common.Models.Swagger.Response.Authentication
{
   public class AuthentictionResponseModel
    {
        // i didn#t find any documention to know what i should with Response Token
        // should i convert it to Base 64 then save it ?
       [JsonPropertyName("token")] public string Token { get; set; }
    }
}
