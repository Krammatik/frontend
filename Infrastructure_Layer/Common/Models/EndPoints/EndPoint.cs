namespace Infrastructure_Layer.Common.Models.EndPoints
{
    public class EndPoint
    {
        public const string BaseUrl = "https://krammatik.deathsgun.xyz";
        public const string LoginUrl = "/auth/login";
        public const string Tasks = "/task";
        public const string RegisterUrl = "/auth/register";
        public const string UserUrl = "/users";
        public const string ValidateTokenUrl = "/auth/validate";
        public const string CurrentUserUrl = "/users/user";
        public const string SpecificUserUrl = "/users/{0}";
    }
}