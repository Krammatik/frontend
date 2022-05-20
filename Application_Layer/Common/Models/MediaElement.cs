namespace Application_Layer.Common.Models;

public class MediaElement
{
    public List<string> Images { get; set; }

    public string Text { get; set; }

    public MediaElement(string text, List<string> images)
    {
        Text = text;
        Images = images;
    }
}