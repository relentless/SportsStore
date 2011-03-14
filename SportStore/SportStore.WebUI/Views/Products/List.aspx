<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<SportStore.WebUI.Models.ProductListViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Products
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <% foreach (var product in Model.Products) { %>
        <% Html.RenderPartial("ProductSummary", product); %>
    <% } %>
    <div class="pager">
    <%= Html.PagingLinks(Model.Paging, pageNum => Url.ProductsList(pageNum)) %>
</div>

<p>Data from: <%=DateTime.Now.ToLongTimeString() %></p>
</asp:Content>
