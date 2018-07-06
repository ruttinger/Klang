<%@ Page Title="Klang" Language="C#" AutoEventWireup="true" CodeBehind="Album.aspx.cs" Inherits="SpotifyAPIApplication.Album"  MasterPageFile="~/yoda.Master"%>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div id="divAlbum" class="articleDiv">
        <div id="divImgAlbum" >
            <asp:Image runat="server" ID="imgAlbumCover"/>
        </div>
        <div id="divListTracks">
            <section class="tracklist-container">
                <ol class="tracklist" id="olTracks" runat="server">

                </ol>
            </section>
        </div>
    </div>
</asp:Content>

