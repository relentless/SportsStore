<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Admin.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<SportStore.Domain.Entities.Product>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Manage Products
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Manage Products</h2>

    <table>
        <tr>
            <th>
                ProductID
            </th>
            <th>
                Name
            </th>
            <th>
                Description
            </th>
            <th>
                Price
            </th>
            <th>
                Category
            </th>
            <th>
                Actions
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            
            <td>
                <%= Html.Encode(item.ProductID) %>
            </td>
            <td>
            <%= Html.ActionLink(item.Name, "Edit", new { item.ProductID })%> 
            </td>
            <td>
                <%= Html.Encode(item.Description) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:c}", item.Price)) %>
            </td>
            <td>
                <%= Html.Encode(item.Category) %>
            </td>
            <td>
            <% using(Html.BeginForm("Delete", "Admin")) { %>
                
                <%= Html.Hidden("ProductId", item.ProductID)%>
                <input type="submit" value="Delete" />
                <% } %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%= Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

