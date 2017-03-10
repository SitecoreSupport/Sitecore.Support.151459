using Sitecore.Diagnostics;
using Sitecore.Modules.EmailCampaign.Core.Extensions;
using Sitecore.Modules.EmailCampaign.Core.Pipelines.GenerateLink;
using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;


namespace Sitecore.Support.Modules.EmailCampaign.Core.Pipelines.GenerateLink.Hyperlink
{ 
    public class HandleAnchorLinks : GenerateLinkProcessor
    {
        public override void Process(GenerateLinkPipelineArgs args)
        {
            Assert.IsNotNull(args, "Arguments can't be null");
            if (args.Url.StartsWith("/#"))
            {
                args.GeneratedUrl = args.Url.Remove(0, 1);                
            }
        }
    }
}