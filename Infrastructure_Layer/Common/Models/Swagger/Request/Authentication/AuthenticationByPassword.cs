using Infrastructure_Layer.Common.Models.EndPoints;
using System;
using System.Collections.Generic;


namespace Infrastructure_Layer.Common.Models.Swagger.Request.Authentication
{
    public class AuthenticationByPassword : BaseLoginRequest
    {
        public AuthenticationByPassword() : base(EndPoint.loginUrl, Method.Post)
        {
            //// assignig Credtionals Body to Request

            AuthenticationPasswordModel model = new AuthenticationPasswordModel("max.musterman", "MusterPassword123");
            this.AddJsonBody(model);

        }

        private class AuthenticationPasswordModel
        {

            [JsonPropertyName("username")] public string UserName { get; }
            [JsonPropertyName("password")] public string Password { get; }
            public AuthenticationPasswordModel(string userName, string password)
            {
                UserName = userName;
                Password = password;
            }

        }
    }
}
