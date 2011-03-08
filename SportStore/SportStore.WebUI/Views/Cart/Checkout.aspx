<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SportStore.Domain.Entities.DeliveryDetails>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Checkout
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>dd</h2>
    
    <%=Html.ValidationSummary() %>
    
    <% using (Html.BeginForm("ConfirmDetails", "Cart")) { %>
    <p>
    <%=Html.LabelFor(x => x.Name)%><%=Html.EditorFor(x => x.Name)%>
    </p>
    <p>
    <%=Html.LabelFor(x => x.Address1)%><%=Html.EditorFor(x => x.Address1)%>
    </p>
    <p>
    <%=Html.LabelFor(x => x.Address2)%><%=Html.EditorFor(x => x.Address2)%>
    </p>
    <p>
    <%=Html.LabelFor(x => x.Postcode)%><%=Html.EditorFor(x => x.Postcode)%>
    </p>
    <p>
    <%=Html.EditorFor(x => x.GiftWrap)%><%=Html.LabelFor(x => x.GiftWrap)%>
    </p>
    
    <input type="submit" value="Order" />
    <% } %>

</asp:Content>
