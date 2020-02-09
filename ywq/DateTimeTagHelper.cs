using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ywq
{
    [HtmlTargetElement("datetime", Attributes = "asp-showicon")]
    public class DateTimeTagHelper:TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";
            output.Content.Clear();

            object showicon = context.AllAttributes["asp-showicon"].Value;

            object only = context.AllAttributes["asp-only"].Value;

            if (showicon.ToString() == "true")
            {
                string str = "glyphicon-calendar";
                output.PreContent.SetHtmlContent($"<span class={str}>"+"</span>");
                //output.PreContent.SetHtmlContent("</span>");\


            }
            if (only.ToString() == "date")
            {
                output.Content.Append(DateTime.Now.ToString("yyyy年MM月dd日"));
            }
            base.Process(context, output);
        }
    }
}
