using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net;
using System.Text;

namespace ScreenScrape
{
    [Cmdlet(VerbsCommon.New, "HTMLDocument")]
    [OutputType(typeof(HtmlDocument))]
    public class NewHTMLDocument : PSCmdlet
    {

        [Parameter(ParameterSetName = "FromString")]
        public string FromString { get; set; }

        [Parameter(ParameterSetName = "FromUri")]
        public string FromUri { get; set; }


        protected override void ProcessRecord()
        {
            var doc = new HtmlDocument();
            if (ParameterSetName == "FromUri")
            {

                var webClient = new System.Net.WebClient();
                var html = webClient.DownloadString(FromUri);
                doc.LoadHtml(html);
            }
            else
            {
                doc.LoadHtml(FromString);
            }

            WriteObject(doc);
        }
    }
}
