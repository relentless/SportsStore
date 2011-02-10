<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<IEnumerable<SportStore.Domain.Entities.Product>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Products
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <% foreach (var product in Model) { %>
        <div class="item">
            <h3><%=Html.Encode(product.Name) %></h3>
            <%=Html.Encode(product.Description) %>
            <h4><%=Html.Encode(product.Price.ToString("c")) %></h4>
        </div>
    <%} %>

</asp:Content>
