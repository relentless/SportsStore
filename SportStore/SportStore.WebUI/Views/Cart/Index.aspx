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
                <th />
            </tr>
        </thead>
        <tbody>
            <% foreach (var line in Model.Cart.Lines) { %>
            <tr>
                <% Html.RenderPartial("CartLine", line); %>
                <td>
                    <%using (Html.BeginForm("RemoveProduct", "Cart")) { %>
                    <%=Html.Hidden("productId", line.Product.ProductID) %>
                    <%=Html.HiddenFor(x => x.RedirectionUrl) %>
                        <input type="submit" value="Remove" />
                    <% } %>
                </td>
            </tr>
            <% } %>
        </tbody>
        <tfoot>
        <tr>
        <td colspan="3" align="right">
        <%=Html.Encode("Total: " + Model.Cart.TotalCost.ToString("c"))%>
        </td>
        <td />
        </tr>
        </tfoot>
    </table>
    <p align="center" class="actionButtons">
    <a href="<%=Model.RedirectionUrl%>">Continue Shopping</a>
    <%=Html.ActionLink("Checkout now", "Checkout") %>
    </p>
    
</asp:Content>
