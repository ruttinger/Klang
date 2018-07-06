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
using System.IO;
using System.Web.Script.Serialization;
using SpotifyAPIApplication.Classes;
using System.Web.UI.HtmlControls;

namespace SpotifyAPIApplication
{
    public partial class Album : System.Web.UI.Page
    {

        private static SpotifyWebAPI _spotify;

        protected void Page_Load(object sender, EventArgs e)
        {
            string albumID;
            albumID = Request.QueryString["album"];

            _spotify = Default._spotify;

            string result = SpotifyResponse.respAlbum(albumID, _spotify, "https://api.spotify.com/v1/albums/");
            var albumResult = new JavaScriptSerializer().Deserialize<ResAlbum.RootObject>(result);

            //OUTPUT OF ELEMENTS
            imgAlbumCover.ImageUrl = albumResult.images[0].url;
            imgAlbumCover.Width = 300;

            foreach (var track in albumResult.tracks.items)
            {
                HtmlGenericControl div = new HtmlGenericControl("div");
                olTracks.Controls.Add(div);

                HtmlGenericControl li = new HtmlGenericControl("li");
                div.Controls.Add(li);

                HtmlGenericControl divName = new HtmlGenericControl("div");
                divName.Attributes.Add("text", track.name);
                li.Controls.Add(divName);
                
                
            }
        }
    }
}