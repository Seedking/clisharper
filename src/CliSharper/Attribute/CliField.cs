namespace CliSharper.Attribute;

[AttributeUsage(AttributeTargets.Field)]
public class CliField : System.Attribute {
    public string shortTag { get; set; }
    public string longTag { get; set; }
    public string description { get; set; }
    public bool isRequired { get; set; }
}