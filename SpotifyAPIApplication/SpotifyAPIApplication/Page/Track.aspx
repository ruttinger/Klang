<%@ Page Title="Klang" Language="C#" AutoEventWireup="true" CodeBehind="Track.aspx.cs" Inherits="SpotifyAPIApplication.Track"  MasterPageFile="~/yoda.Master"%>

<asp:Content class="MainClass" ContentPlaceHolderID="MainContent" runat="server">
    <div class="articleDiv">
        <asp:Label runat="server" ID="lblTrckTitle" CssClass="pageTitle"/>
        <asp:Image runat="server" ID="imgTrckCover" CssClass="imageCover"/>
    </div>
</asp:Content>
