<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Admin.Master" Inherits="System.Web.Mvc.ViewPage<SportStore.Domain.Entities.Product>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit Product <%=Html.Encode(Model.Name) %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit Product <%=Html.Encode(Model.Name) %></h2>
    <% using(Html.BeginForm()) { %>
    <%=Html.EditorForModel() %>
<input type="submit" value="save" />
<% } %>

<%=Html.ActionLink("Cancel", "Index") %>
</asp:Content>
