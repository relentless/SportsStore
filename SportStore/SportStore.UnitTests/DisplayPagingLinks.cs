using System;
using NUnit.Framework;
using System.Web.Mvc;
using SportStore.WebUI.Models;
using SportStore.WebUI.HtmlHelpers;

namespace SportStore.UnitTests
{
    [TestFixture]
public class DisplayPagingLinks {
	[Test]
	public void can_generate_links_to_other_pages() {
		// arrange
		HtmlHelper helper = null;
		
		PagingInfo info = new PagingInfo {
			CurrentPage = 2,
			TotalItems = 14,
			ItemsPerPage = 5
		};
		
		Func<int, string> pageUrl = page => "Page" + page;
		
		// act
		MvcHtmlString result = helper.PagingLinks(info, pageUrl);
		
		// assert
		result.ToString().ShouldEqual(@"<a href=""Page1"">1</a>" + Environment.NewLine +
                                        @"<a class=""selected"" href=""Page2"">2</a>" + Environment.NewLine +
                                        @"<a href=""Page3"">3</a>" + Environment.NewLine +
                                        "");
	}
}

}
