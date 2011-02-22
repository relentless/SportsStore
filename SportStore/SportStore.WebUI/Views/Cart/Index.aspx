<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SportStore.WebUI.Models.CartViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Your Cart</h2>
    
    <% foreach (var line in Model.Cart.Lines) { %>
    <p>
    <%=Html.Encode(line.Product.Name) %>&nbsp;<%=Html.Encode(line.Product.Price.ToString("c")) %>
    </p>
    <% } %>
    
    <a href="<%=Model.RedirectionUrl%>">Continue Shopping</a>

</asp:Content>
