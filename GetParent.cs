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
        [Cmdlet(VerbsCommon.Get, "Parent")]
        [OutputType(typeof(HtmlDocument))]
        public class GetParent : PSCmdlet
        {
            [Parameter(Mandatory = true)]
            public string Selector { get; set; }

            [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = "HtmlNode")]
            public HtmlNode HtmlNode { get; set; }


            protected override void ProcessRecord()
            {
                var result = GetParentNode(HtmlNode, Selector);
                WriteObject(result);
            }


            private HtmlNode GetParentNode(HtmlNode node, string selector)
            {
                if (node.ParentNode == null)
                {
                    return null;
                }
                var matchNode = node.ParentNode.QuerySelector(selector);

                if (node == matchNode)
                {
                    return matchNode;
                }
                else
                {
                    return GetParentNode(node.ParentNode, selector);
                }
            }
        }
    }

