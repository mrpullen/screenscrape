using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScrape
{
    [Cmdlet(VerbsCommon.Get, "Element")]
    [OutputType(typeof(HtmlDocument))]
    public class GetElement: PSCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = "HtmlDocument")]
        public HtmlDocument HtmlDocument { get; set; }

        [Parameter(Mandatory = true)]
        public string Selector { get; set; }

        [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = "HtmlNode")]
        public HtmlNode HtmlNode { get; set; }


        protected override void ProcessRecord()
        {
            if (ParameterSetName == "HtmlDocument")
            {
                var results = HtmlDocument.DocumentNode.QuerySelector(Selector);
                WriteObject(results);
            }
            else
            {
                var results = HtmlNode.QuerySelector(Selector);
                WriteObject(results);
            }
        }
    }
}
