<%@ Page Title="Review" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Review.aspx.cs" Inherits="PlanetWrox.Ui.Review" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DropDownList ID="drpGenre" runat="server" AutoPostBack="true" 
        AppendDataBoundItems="true" 
        onselectedindexchanged="drpGenre_SelectedIndexChanged">
        <asp:ListItem Text="Select Genre..." />
    </asp:DropDownList>
    <asp:GridView ID="grdReview" runat="server">
    </asp:GridView>
</asp:Content>
