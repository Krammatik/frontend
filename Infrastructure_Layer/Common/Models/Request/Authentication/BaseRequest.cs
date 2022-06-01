namespace Infrastructure_Layer.Common.Models.Request.Authentication
{
    public class BaseRequest : RestRequest
    {
        protected BaseRequest(string resource, Method method) : base(resource, method)
        {
            this.AddHeader("Content-Type", "application/json");
            this.AddHeader("Accept", "application/json");
        }
    }
}