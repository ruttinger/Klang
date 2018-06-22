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

namespace SpotifyAPIApplication
{
    public partial class Search : System.Web.UI.Page
    {
        private static SpotifyWebAPI _spotify;
        SearchItem _search;

        public string searchTxt = "damn";

        protected void Page_Load(object sender, EventArgs e)
        {
            AsyncContext.Run(() => MainAsync());

            _search = _spotify.SearchItems(searchTxt, SearchType.Album);

            List<SimpleAlbum> nList = new List<SimpleAlbum>(_search.Albums.Items);

            //DataTable dt = new DataTable();
            //dt.Columns.AddRange(new DataColumn[1]
            //{
            //    new DataColumn("Album-Name",typeof(string))
            //});
            //foreach (var album in nList)
            //{
            //    if (dt.Select().ToList().Exists(row => row["Album-Name"].ToString().ToUpper() == album.Name))
            //    {
                    
            //    }
            //    dt.Columns.Add(new DataColumn(album.Name, typeof(string)));
            //}
            //for (int i = 0; i < dt.Columns.Count; i++)
            //{
            //    lblAlbums.Text = dt.Rows[i][0].ToString();
            //}
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