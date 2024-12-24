using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.TagHelpers
{
    public class PhoneTagHelper :TagHelper
    {
        public string PhoneNumber { get; set; } = "0033";
        public string PhoneColor { get; set; } = "green";
        public string PhoneText { get; set; } = "CALL";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
             output.TagName ="a";
            output.Attributes.SetAttribute ("href", $"tel:{ PhoneNumber}");
            output.Attributes.SetAttribute("style", "color:{PhoneColor}");
            output.Content.SetContent(PhoneText);
        }
    }
}
