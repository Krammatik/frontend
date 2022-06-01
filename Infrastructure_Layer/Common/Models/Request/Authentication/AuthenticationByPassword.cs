namespace Infrastructure_Layer.Common.Models.Request.Authentication
{
    public class AuthenticationByPassword : BaseRequest
    {
        public AuthenticationByPassword(string username, string password) : base(EndPoint.LoginUrl, Method.Post)
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
