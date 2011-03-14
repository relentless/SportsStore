<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<SportStore.Domain.Entities.CartLine>" %>
    <td align="left">
        <%=Html.Encode(Model.Product.Name)%>
    </td>
    <td align="right">
        <%=Html.Encode(Model.Quantity)%>
    </td>
    <td align="right">
        <%=Html.Encode(Model.TotalPrice.ToString("c"))%>
    </td>
