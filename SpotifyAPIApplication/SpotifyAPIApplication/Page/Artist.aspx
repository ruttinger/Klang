<%@ Page Title="Klang" Language="C#" AutoEventWireup="true" CodeBehind="Artist.aspx.cs" Inherits="SpotifyAPIApplication.Artist"  MasterPageFile="~/yoda.Master"%>

<asp:Content class="MainClass" ContentPlaceHolderID="MainContent" runat="server">
        <!-- Artist Name and Picture -->
    <div class="backgroundContainer">

        <asp:Image runat="server" ID="imgArtistPicture" />

        <div class="CenterHeader">
            <asp:Label runat="server" ID="lblArtistListener" />
            <asp:Label runat="server" ID="lblArtistName" />
        </div>

    </div>

    <!-- More Informations -->
    <div class="ContentCntainer">

        <%-- Tabs --%>
        <div class="tab">
            <div class="tabButtonContainer">
                <button class="tablinks" onclick="openCity(event, 'London')">OVERVIEW</button>
                <button class="tablinks" onclick="openCity(event, 'Paris')">RELATED ARTISTS</button>
                <button class="tablinks" onclick="openCity(event, 'Tokyo')">ABOUT</button>
            </div>

            <div id="London" class="tabcontent">
                <h3>Popular</h3>
                <p>All The Stars</p>
                <p>HUMBLE.</p>
                <p>DNA.</p>
            </div>

            <div id="Paris" class="tabcontent">
                <h3>Paris</h3>
                <p>Paris is the capital of France.</p>
            </div>

            <div id="Tokyo" class="tabcontent">
                <h3>Tokyo</h3>
                <p>Tokyo is the capital of Japan.</p>
            </div>

        </div>


        <!-- Skript for Tabs -->
        <script>
            function openCity(evt, cityName) {
                var i, tabcontent, tablinks;
                tabcontent = document.getElementsByClassName("tabcontent");
                for (i = 0; i < tabcontent.length; i++) {
                    tabcontent[i].style.display = "none";
                }
                tablinks = document.getElementsByClassName("tablinks");
                for (i = 0; i < tablinks.length; i++) {
                    tablinks[i].className = tablinks[i].className.replace(" active", "");
                }
                document.getElementById(cityName).style.display = "block";
                evt.currentTarget.className += " active";
            }
        </script>
</asp:Content>