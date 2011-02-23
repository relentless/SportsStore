<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SportStore.WebUI.Models.CartViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Your Cart</h2>
    <table width="90%">
        <thead>
            <tr>
                <th align="left">
                    Product
                </th>
                <th align="right">
                    Quantity
                </th>
                <th align="right">
                    Subtotal
                </th>
            </tr>
        </thead>
        <tbody>
            <% foreach (var line in Model.Cart.Lines) { %>
            <tr>
                <td align="left">
                    <%=Html.Encode(line.Product.Name)%>
                </td>
                <td align="right">
                    <%=Html.Encode(line.Quantity)%>
                </td>
                <td align="right">
                    <%=Html.Encode(line.TotalPrice.ToString("c"))%>
                </td>
            </tr>
            <% } %>
        </tbody>
        <tfoot>
        <tr>
        <td colspan="3" align="right">
        <%=Html.Encode("Total: " + Model.Cart.TotalCost.ToString("c"))%>
        </td>
        </tr>
        </tfoot>
    </table>
    <p align="center" class="actionButtons">
    <a href="<%=Model.RedirectionUrl%>">Continue Shopping</a>
    </p>
    
</asp:Content>
