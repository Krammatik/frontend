using Infrastructure_Layer.Common.Models.Request.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Common.Models.Request.Register
{
    public class SignupRequest:BaseRequest
    {
        public SignupRequest(string username, string password) : base(EndPoint.RegisterUrl, Method.Post)
        {
            this.AddJsonBody(new AuthenticationPasswordModel(username, password));
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
