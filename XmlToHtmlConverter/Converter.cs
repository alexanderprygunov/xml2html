using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Configuration;
using XmlToHtmlConverter.HtmlGenerator;
using XmlToHtmlConverter.HtmlGenerator.Models;
using XmlToHtmlConverter.XmlParsing;

namespace XmlToHtmlConverter.Core
{
    class Converter
    {
        private static List<Node> Nodes = new List<Node>();
        private static readonly StringBuilder Html = new StringBuilder();
        private static readonly HtmlPageGenerator HtmlPageGenerator = new HtmlPageGenerator();
        private static readonly XmlDataParsing XmlDataParsing = new XmlDataParsing();

        static void Main(string[] args)
        {

            if (args.Length != 1)
            {
                return;
            }

            try
            {
                var document = args[0];
                var root = XElement.Load(document);
                Nodes = XmlDataParsing.CreateNodeList(root);
                GenerateHtmlFile();
            }

            catch (Exception)
            {
                Console.WriteLine("Error Converting XML to HTML document");
                throw;
            }

        }

        private static void GenerateHtmlFile()
        {
            Html.AppendLine(HtmlPageGenerator.PrepareHtml(Nodes));
            File.WriteAllText(ConfigurationManager.AppSettings.Get("htmlFile"), Html.ToString());
        }

    }
}
