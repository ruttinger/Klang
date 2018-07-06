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

namespace SpotifyAPIApplication
{
    public partial class Track : System.Web.UI.Page
    {
        private static SpotifyWebAPI _spotify;
        protected void Page_Load(object sender, EventArgs e)
        {
            string trackID;
            trackID = Request.QueryString["track"];

            _spotify = Default._spotify;

            string result = SpotifyResponse.respAlbum(trackID, _spotify, "https://api.spotify.com/v1/tracks/");
            var trackResult = new JavaScriptSerializer().Deserialize<ResTrack.RootObject>(result);

            lblTrckTitle.Text = trackResult.name;
            imgTrckCover.ImageUrl = trackResult.album.images[0].url;
            imgTrckCover.Width = 100;
            
        }
    }
}