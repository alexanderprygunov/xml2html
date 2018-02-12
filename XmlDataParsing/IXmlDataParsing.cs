using System.Collections.Generic;
using System.Xml.Linq;
using XmlToHtmlConverter.HtmlGenerator.Models;

namespace XmlToHtmlConverter.XmlParsing
{
    public interface IXmlDataParsing
    {
        List<Node> CreateNodeList(XElement element);
    }
}