using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace taghelperdemo.TagHelpers
{
    [HtmlTargetElement("secure-link")]
    public class SecureLinkTagHelper : TagHelper
    {
        [HtmlAttributeName("asp-page-name")]
        public string PageName { get; set; }

        public List<string> PageNames { get; set; }

        public SecureLinkTagHelper()
        {
            PageNames = new List<string>
            {
                "Home",
                "About",
                "Contact"
            };
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";

            if(PageNames.Any(x=>x == PageName))
            {
                return;
            }
            output.SuppressOutput();
        }
    }
}
