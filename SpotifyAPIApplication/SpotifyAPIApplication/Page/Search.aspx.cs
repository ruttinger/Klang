using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using SpotifyAPI.Web.Auth;
using Nito.AsyncEx;
using System.Data;
using System.Text;

namespace SpotifyAPIApplication
{
    public partial class Search : System.Web.UI.Page
    {
        private static SpotifyWebAPI _spotify;
        SearchItem _search;

        string searchTxt;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Searchtoken übernehmen
            searchTxt = Request.QueryString["search"];

            //Authentifizierung
            AsyncContext.Run(() => MainAsync());

            //SearchItem mit dem übergegebenen Searchtoken zuweisen
            _search = _spotify.SearchItems(searchTxt, SearchType.Album | SearchType.Artist | SearchType.Track);
            
            //Listen erstellen
            List<SimpleAlbum> listAlbums = new List<SimpleAlbum>(_search.Albums.Items);

            List<FullArtist> listArtists = new List<FullArtist>(_search.Artists.Items);

            List<FullTrack> listTracks = new List<FullTrack>(_search.Tracks.Items);


            //Filterlisten erstellen
            List<string> filteredAlbum = new List<string>();

            List<string> filteredArtist = new List<string>();

            List<string> filteredTrack = new List<string>();

            //Werte in Filtertabelle
            for (int i = 0; i < listAlbums.Count; i++)
            {
                string [] output = new string[] {listAlbums[i].Name};
                filteredAlbum.InsertRange(filteredAlbum.Count,output);
            }

            for (int i = 0; i < listArtists.Count; i++)
            {
                string[] output = new string[] { listArtists[i].Name };
                filteredArtist.InsertRange(filteredArtist.Count, output);
            }

            for (int i = 0; i < listTracks.Count; i++)
            {
                string[] output = new string[] { listTracks[i].Name };
                filteredTrack.InsertRange(filteredTrack.Count, output);
            }


            //Filtertabelle zu GridView
            gvAlbum.DataSource = filteredAlbum;
            gvAlbum.DataBind();

            gvArtist.DataSource = filteredArtist;
            gvArtist.DataBind();

            gvTrack.DataSource = filteredTrack;
            gvTrack.DataBind();

            //Headercells benennen
            foreach (TableCell cell in gvAlbum.HeaderRow.Cells)
            {
                cell.Text = "Album";
            }
            foreach (TableCell cell in gvArtist.HeaderRow.Cells)
            {
                cell.Text = "Artist";
            }
            foreach (TableCell cell in gvTrack.HeaderRow.Cells)
            {
                cell.Text = "Track";
            }

            //ROW BUTTON
            for (int i = 0; i < gvAlbum.Rows.Count; i++)
            {
                gvAlbum.Rows[i].Attributes.Add("onclick", "javascript: window.location = 'Album.aspx?album="+listAlbums[i].Id+"'; ");
            }
            for (int i = 0; i < gvArtist.Rows.Count; i++)
            {
                gvArtist.Rows[i].Attributes.Add("onclick", "javascript: window.location = 'Artist.aspx?artist=" + listArtists[i].Id + "'; ");
            }
            for (int i = 0; i < gvTrack.Rows.Count; i++)
            {
                gvTrack.Rows[i].Attributes.Add("onclick", "javascript: window.location = 'Track.aspx?track=" + listTracks[i].Id + "'; ");
            }
        }


        static async void MainAsync()
        {
            WebAPIFactory webApiFactory = new WebAPIFactory(
                "http://localhost/",
                8000,
                "6bf25efedbd74e0b905868f562b82fee",
                Scope.UserReadPrivate,
                TimeSpan.FromSeconds(20)
                );

            try
            {
                _spotify = await webApiFactory.GetWebApi();
            }
            catch(Exception)
            {

            }

            if (_spotify == null)
                return;
        }
        public void btnTemp()
        {
            gvAlbum.BackColor = System.Drawing.Color.Blue;
        }
    }
}