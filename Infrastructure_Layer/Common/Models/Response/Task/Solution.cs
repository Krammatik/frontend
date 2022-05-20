namespace Infrastructure_Layer.Common.Models.Response.Task;

public class Solution
{
    [JsonPropertyName("value")] public string Value { get; set; }
    [JsonPropertyName("correct")] public bool Correct { get; set; }
    
    public Application_Layer.Common.Models.Solution ToAppSolution()
    {
        return new Application_Layer.Common.Models.Solution(Value, Correct);
    }
    
}