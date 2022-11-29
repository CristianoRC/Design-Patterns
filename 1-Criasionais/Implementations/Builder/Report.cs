namespace criacionais.Implementations.Builder;

public class Report
{
    public Report(string name, string extension, string content)
    {
        Name = name;
        Extension = extension;
        Content = content;
    }

    public string Name { get; }
    public string Extension { get; }
    public string Content { get; }
}