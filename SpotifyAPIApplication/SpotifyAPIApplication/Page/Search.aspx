<%@ Page Title="Klang" Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="SpotifyAPIApplication.Search" MasterPageFile="~/yoda.Master" %>

    
<asp:Content class="MainClass" ContentPlaceHolderID="MainContent" runat="server">
    <%--stylesheet--%>
    <link rel="stylesheet" type="text/css" href="~/Style/Default.css" />
    

    
    <asp:gridview runat="server" id="gvAlbum" cssclass="GridView" forecolor="White" />
    <asp:gridview runat="server" id="gvArtist" cssclass="GridView" forecolor="White" />
    <asp:gridview runat="server" id="gvTrack" cssclass="GridView" forecolor="White" />

    

</asp:Content>
