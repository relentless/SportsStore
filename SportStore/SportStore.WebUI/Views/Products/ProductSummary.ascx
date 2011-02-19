<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<SportStore.Domain.Entities.Product>" %>
<div class="item">
    <h3><%=Html.Encode(Model.Name) %></h3>
    <%=Html.Encode(Model.Description)%>
    <h4><%=Html.Encode(Model.Price.ToString("c"))%></h4>
</div>
