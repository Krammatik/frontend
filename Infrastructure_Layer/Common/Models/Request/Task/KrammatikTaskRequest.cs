namespace Infrastructure_Layer.Common.Models.Request.Task;

public class KrammatikTaskRequest : RestRequest
{
    public KrammatikTaskRequest(string token) : base(EndPoint.Tasks)
    {
        this.AddHeader("Accept", "application/json");
        this.AddHeader("Authorization", $"Bearer {token}");
    }
}