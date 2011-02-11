using System;
using System.Text;
using System.Web.Mvc;
using SportStore.WebUI.Models;

namespace SportStore.WebUI.HtmlHelpers {
    public static class PagingHelpers {
        public static MvcHtmlString PagingLinks(this HtmlHelper helper, PagingInfo pageInfo, Func<int, string> calculatePageUrl){
		StringBuilder pagingString = new StringBuilder();

        for (int page = 1; page <= pageInfo.TotalPages; page++) {
            TagBuilder anchorTag = new TagBuilder("a");
            anchorTag.MergeAttribute("href", calculatePageUrl(page));
            anchorTag.InnerHtml = page.ToString();

            if (page == pageInfo.CurrentPage) {
                anchorTag.AddCssClass("selected");
            }

            pagingString.AppendLine(anchorTag.ToString());
        }
		
		return  MvcHtmlString.Create(pagingString.ToString());
	}
    }
}
