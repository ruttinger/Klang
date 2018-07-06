<%@ Page Title="Klang" Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="SpotifyAPIApplication.Search" MasterPageFile="~/yoda.Master" %>


<asp:Content class="MainClass" ContentPlaceHolderID="MainContent" runat="server">
    <%--stylesheet--%>
    <link rel="stylesheet" type="text/css" href="~/Style/Default.css" />


    <div class="SearchContainer">
        <asp:GridView runat="server" ID="gvAlbum" CssClass="GridView" ForeColor="White" />
        <asp:GridView runat="server" ID="gvArtist" CssClass="GridView" ForeColor="White" />
        <asp:GridView runat="server" ID="gvTrack" CssClass="GridView" ForeColor="White" />
    </div>

</asp:Content>
