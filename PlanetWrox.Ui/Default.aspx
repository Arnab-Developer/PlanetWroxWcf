<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="PlanetWrox.Ui._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <ul>
        <li><a href="/Genre.aspx">Genre</a></li>
        <li><a href="/Review.aspx">Review</a></li>
    </ul>
</asp:Content>
