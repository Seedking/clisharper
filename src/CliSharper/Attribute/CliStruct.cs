namespace CliSharper.Attribute;

[AttributeUsage(AttributeTargets.Struct)]
public class CliStruct : System.Attribute {
    public string name { get; set; }
    public string bindCommand { get; set; }
    public bool isRequired { get; set; }
}