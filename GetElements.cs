using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;
using System;
using System.Management.Automation;
using System.Collections.Generic;

namespace ScreenScrape
{
    [Cmdlet(VerbsCommon.Get, "Elements")]
    [OutputType(typeof(IEnumerable<HtmlDocument>))]
    public class GetElements : PSCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = "HtmlDocument")]
        public HtmlDocument HtmlDocument { get; set; }

        [Parameter(Mandatory = true)]
        public string Selector { get; set; }

        [Parameter(Mandatory=true, ValueFromPipeline = true, ParameterSetName = "HtmlNode")]
        public HtmlNode HtmlNode { get; set; }
        protected override void ProcessRecord()
        {
            
            if (ParameterSetName == "HtmlDocument")
            {
                var results = HtmlDocument.DocumentNode.QuerySelectorAll(Selector);
                WriteObject(results);
            }
            else
            {
                var results = HtmlNode.QuerySelectorAll(Selector);
                WriteObject(results);
            }
                
        }

    }
}
