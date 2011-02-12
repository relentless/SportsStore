<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<SportStore.WebUI.Models.ProductListViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Products
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <% foreach (var product in Model.Products) { %>
        <div class="item">
            <h3><%=Html.Encode(product.Name) %></h3>
            <%=Html.Encode(product.Description) %>
            <h4><%=Html.Encode(product.Price.ToString("c")) %></h4>
        </div>
    <%} %>
    
    <%= Html.PagingLinks(Model.Paging, pageNum => Url.Action("List", new { page = pageNum})) %>

</asp:Content>
