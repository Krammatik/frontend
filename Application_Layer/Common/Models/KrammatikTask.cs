namespace Application_Layer.Common.Models;

public class KrammatikTask
{
    public string Id { get; set; }
    public string Title { get; set; }
    public MediaElement GeneralDescription { get; set; }
    public double Score { get; set; }
    public List<Solution> Solutions { get; set; }
    public string AssignmentDescription { get; set; }
    public MediaElement Hint { get; set; }
    public List<string> RecommendedTasks { get; set; }
}