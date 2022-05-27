namespace Infrastructure_Layer.Common.Models.Response.Task;

/**
     * "id": "5f3e4217-1a40-46a6-b053-33b9448a45fc",
        "type": "DEFAULT",
        "title": "test",
        "description": {
            "text": "test",
            "imgData": []
        },
        "score": 5.0,
        "solutions": [
            {
                "value": "test",
                "correct": true
            }
        ],
        "hint": {
            "text": "test",
            "imgData": []
        },
        "recommendations": [],
        "value": "Test"
     */
public class KrammatikTaskResponse
{
    [JsonPropertyName("id")] public string Id { get; set; }
    [JsonPropertyName("title")] public string Title { get; set; }
    [JsonPropertyName("description")] public MediaElement Description { get; set; }
    [JsonPropertyName("score")] public double Score { get; set; }
    [JsonPropertyName("solutions")] public List<Solution> Solutions { get; set; }
    [JsonPropertyName("value")] public string Value { get; set; }
    [JsonPropertyName("hint")] public MediaElement Hint { get; set; }
    [JsonPropertyName("recommendations")] public List<string> Recommendations { get; set; }
}