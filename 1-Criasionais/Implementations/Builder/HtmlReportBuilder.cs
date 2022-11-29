using System.Text;

namespace criacionais.Implementations.Builder;

public class HtmlReportBuilder
{
    private readonly StringBuilder _content;

    public HtmlReportBuilder()
    {
        _content = new StringBuilder();
        AddInitialStructure();
    }

    private HtmlReportBuilder AddInitialStructure()
    {
        _content.AppendLine("Estrutura Inicial");
        return this;
    }

    public HtmlReportBuilder AddHeader()
    {
        _content.AppendLine("Eu Sou Header");
        return this;
    }


    public HtmlReportBuilder AddSummary()
    {
        _content.AppendLine("Eu sou Summary");
        return this;
    }

    public HtmlReportBuilder AddItems(string[] items)
    {
        foreach (var item in items)
        {
            _content.AppendLine(item);
        }

        return this;
    }

    public Report Build()
    {
        var fileName = $"report_{DateTime.Now.ToString("hhmmss")}";
        return new Report(fileName, "html", _content.ToString());
    }
}