namespace Infrastructure_Layer.Common.Models.Response;

public class MediaElement
{
    [JsonPropertyName("text")] public string Text { get; set; }
    [JsonPropertyName("imgData")] public List<string> Images { get; set; }

    public Application_Layer.Common.Models.MediaElement ToAppMediaElement()
    {
        return new Application_Layer.Common.Models.MediaElement(Text, Images);
    }
    
}