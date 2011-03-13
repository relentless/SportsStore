<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SportStore.WebUI.Models.AccountViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	LogOn
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>LogOn</h2>
    <%=Html.ValidationSummary(true) %>
    <% Html.EnableClientValidation(); %>
    <% using (Html.BeginForm()) { %>
    <%=Html.EditorForModel()%>
    <input type="submit" value="Log On" />
<% } %>
</asp:Content>
