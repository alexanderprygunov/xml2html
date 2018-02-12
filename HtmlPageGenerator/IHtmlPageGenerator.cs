using System.Collections.Generic;
using XmlToHtmlConverter.HtmlGenerator.Models;

namespace XmlToHtmlConverter.HtmlGenerator
{
    public interface IHtmlPageGenerator
    {
        string PrepareHtml(List<Node> nodes);
    }
}
