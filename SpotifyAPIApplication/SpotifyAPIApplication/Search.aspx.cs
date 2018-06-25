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
            searchTxt = Request.QueryString["search"];
            AsyncContext.Run(() => MainAsync());

            _search = _spotify.SearchItems(searchTxt, SearchType.Album);

            List<SimpleAlbum> nList = new List<SimpleAlbum>(_search.Albums.Items);

            gvResult.DataSource = nList;
            gvResult.DataBind();
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
    }
}