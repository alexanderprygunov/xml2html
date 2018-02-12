using System.Collections.Generic;
using System.Configuration;
using XmlToHtmlConverter.HtmlGenerator.Models;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;

namespace XmlToHtmlConverter.HtmlGenerator
{
    public class HtmlPageGenerator : IHtmlPageGenerator
    {
        public string PrepareHtml(List<Node> nodes)
        {
            var model = new NodeModel { Nodes = nodes };

            var templateManager = new ResolvePathTemplateManager(new[] { @"..\..\..\HtmlPageGenerator\Templates" });
            var config = new TemplateServiceConfiguration
            {
                TemplateManager = templateManager
            };

            Engine.Razor = RazorEngineService.Create(config);
            return Engine.Razor.RunCompile(ConfigurationManager.AppSettings.Get("xmlTemplateName"), null, model);
        }
    }
}
