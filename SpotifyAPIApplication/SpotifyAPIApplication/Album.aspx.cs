using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nito.AsyncEx;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Enums;
using System.Net;

namespace SpotifyAPIApplication
{
    public partial class Album : System.Web.UI.Page
    {
        public FullAlbum faAlbum;

        private static SpotifyWebAPI _spotify;

        SearchItem aSearch;
        protected void Page_Load(object sender, EventArgs e)
        {

            faAlbum = new FullAlbum();
            faAlbum.Id = Request.QueryString["album"];

            AsyncContext.Run(() => MainAsync());

            aSearch = _spotify.SearchItems(faAlbum.Id, SearchType.Album);

            
            

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
            catch (Exception)
            {

            }

            if (_spotify == null)
                return;
        }
    }
}