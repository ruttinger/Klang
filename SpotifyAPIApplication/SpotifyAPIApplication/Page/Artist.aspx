<%@ Page Title="Klang" Language="C#" AutoEventWireup="true" CodeBehind="Artist.aspx.cs" Inherits="SpotifyAPIApplication.Artist" MasterPageFile="~/yoda.Master" %>

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




        <!-- More Informations -->

        <%-- Tabs --%>
        <div class="tabset">

            <!-- Tab 1 -->
            <input type="radio" name="tabset" id="tab1" aria-controls="marzen" checked>
            <label for="tab1">OVERVIEW</label>

            <!-- Tab 2 -->
            <input type="radio" name="tabset" id="tab2" aria-controls="rauchbier">
            <label for="tab2">RELATED ARTISTS</label>

            <!-- Tab 3 -->
            <input type="radio" name="tabset" id="tab3" aria-controls="dunkles">
            <label for="tab3">ABOUT</label>

            <div class="tab-panels">
                <section id="marzen" class="tab-panel">

                    <div ID="popularContainer" runat="server">
                        <h2>Popular</h2>

                    </div>

                    <div class="albumContainer">
                        <h2>Popular</h2>
                        <p>Album Design</p>
                    </div>

                </section>
                <section id="rauchbier" class="tab-panel">
                    <h2>6B. Rauchbier</h2>
                    <p><strong>Overall Impression:</strong>  An elegant, malty German amber lager with a balanced, complementary beechwood smoke character. Toasty-rich malt in aroma and flavor, restrained bitterness, low to high smoke flavor, clean fermentation profile, and an attenuated finish are characteristic.</p>
                    <p><strong>History:</strong> A historical specialty of the city of Bamberg, in the Franconian region of Bavaria in Germany. Beechwood-smoked malt is used to make a Märzen-style amber lager. The smoke character of the malt varies by maltster; some breweries produce their own smoked malt (rauchmalz).</p>
                </section>
                <section id="dunkles" class="tab-panel">
                    <h2>6C. Dunkles Bock</h2>
                    <p><strong>Overall Impression:</strong> A dark, strong, malty German lager beer that emphasizes the malty-rich and somewhat toasty qualities of continental malts without being sweet in the finish.</p>
                    <p><strong>History:</strong> Originated in the Northern German city of Einbeck, which was a brewing center and popular exporter in the days of the Hanseatic League (14th to 17th century). Recreated in Munich starting in the 17th century. The name “bock” is based on a corruption of the name “Einbeck” in the Bavarian dialect, and was thus only used after the beer came to Munich. “Bock” also means “Ram” in German, and is often used in logos and advertisements.</p>
                </section>
            </div>

        </div>




    </div>

</asp:Content>
