<%@ Page Title="Klang" Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="SpotifyAPIApplication.Search"  MasterPageFile="~/yoda.Master"%>

<asp:Content class="MainClass" ContentPlaceHolderID="MainContent" runat="server">
    <%--stylesheet--%>
    <link rel="stylesheet" type="text/css" href="~/Style/Default.css" />



    <asp:Label ID="lblAlbums" runat="server"/>
    <asp:GridView runat="server" ID="gvResult" CssClass="GridView" ForeColor="White"></asp:GridView>
</asp:Content>