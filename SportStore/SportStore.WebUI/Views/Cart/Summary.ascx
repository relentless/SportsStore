<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<SportStore.Domain.Entities.Cart>" %>

<% if (Model.Lines.Count > 0) { %>
<div id="cart">
<span class="caption">
<strong>Your Cart:</strong>
<%=Model.Lines.Sum(x => x.Quantity) %> items,
<%=Model.TotalCost.ToString("c") %>
</span>
<%=Html.ActionLink("Checkout", "Index", "Cart", new { redirectToUrl = Request.Url.PathAndQuery }, null )%>
</div>
<% } %>