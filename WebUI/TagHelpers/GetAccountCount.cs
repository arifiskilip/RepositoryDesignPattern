using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;
using WebUI.Entities.Context;

namespace WebUI.TagHelpers
{
    [HtmlTargetElement("getAccountCount")]
    public class GetAccountCount : TagHelper
    {
        private readonly MiniTransferContext _context;

        public GetAccountCount(MiniTransferContext context)
        {
            _context = context;
        }

        public int UserId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var accountCount = _context.Accounts.Count(x=> x.UserId == UserId);
            var html = $"<div class='badge bg-danger'>{accountCount}</div>";
            output.Content.SetHtmlContent(html);
        }
    }
}
