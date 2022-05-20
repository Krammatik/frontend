namespace Application_Layer.Common.Models;

public class Solution
{
    public string Value { get; set; }
    public bool Correct { get; set; }

    public Solution(string value, bool correct)
    {
        Value = value;
        Correct = correct;
    }

}