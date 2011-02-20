﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<SportStore.WebUI.Models.ProductListViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Products
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Categories" runat="server">
<%Html.RenderAction("CategoryList", new { currentCategory = Model.Category }); %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<h1>Products: <%=Html.Encode(Model.Category) %></h1>

    <% foreach (var product in Model.Products) { %>
        <% Html.RenderPartial("ProductSummary", product); %>
    <%} %>
    <div class="pager">
    <%= Html.PagingLinks(Model.Paging, pageNum => Url.Action("List", new { page = pageNum })) %>
</div>
</asp:Content>
