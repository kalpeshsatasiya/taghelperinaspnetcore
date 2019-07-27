using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace taghelperdemo.TagHelpers
{
    [HtmlTargetElement("secure-content")]
    public class SecureContentTagHelper : TagHelper
    {
        public List<string> PageNames { get; set; }
        [HtmlAttributeName("asp-page-name")]
        public string PageName { get; set; }

        public SecureContentTagHelper()
        {
            PageNames = new List<string>
            {
                "Home",
                "About",
                "Contact",
                "Help"
            };
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";

            if (PageNames.Any(x => x == PageName))
            {
                return;
            }

            output.SuppressOutput();
        }

    }
}
