<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<CategoryLink>>" %>
<%@ Import Namespace="SportStore.WebUI.Models" %>
<% foreach (CategoryLink link in Model) { %>
       <%=Html.ActionLink(
           link.Category, 
           link.Action, 
           link.Controller, 
           new { category = link.Category },
           link.IsSelected ? new { @class = "selected" }:null)%>
   <%}%>
