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
    public partial class Artist : System.Web.UI.Page
    {
        private static SpotifyWebAPI _spotify;
        public HtmlGenericControl TopSongsContainer = new HtmlGenericControl("div");
        protected void Page_Load(object sender, EventArgs e)
        {
            string artistID;
            artistID = Request.QueryString["artist"];

            _spotify = Default._spotify;








            //GET ARTIST
            // Artist Title
            string resultArtist = SpotifyResponse.respAlbum(artistID, _spotify, "https://api.spotify.com/v1/artists/");
            var artistResult = new JavaScriptSerializer().Deserialize<ResArtist.RootObject>(resultArtist);

            lblArtistName.Text = artistResult.name;
            imgArtistPicture.ImageUrl = artistResult.images[0].url;
            lblArtistListener.Text = artistResult.popularity.ToString() + "% Popularity";



            // GET TOP SONGS
            string resultTracks = SpotifyResponse.respTopTracks(artistID, _spotify, "https://api.spotify.com/v1/artists/");
            var toptracksResult = new JavaScriptSerializer().Deserialize<ResTopTracks.Welcome>(resultTracks);

            

            for (int i = 0; i < 5; i++)
            {
                HtmlGenericControl SongTitle = new HtmlGenericControl("p")
                {
                    InnerHtml = toptracksResult.Tracks[i].Name
                };
                TopSongsContainer.Controls.Add(SongTitle);


                HtmlGenericControl SongDuration = new HtmlGenericControl("p")
                {
                    InnerHtml = toptracksResult.Tracks[i].DurationMs.ToString()
                };
                TopSongsContainer.Controls.Add(SongDuration);


                HtmlGenericControl SongExplict = new HtmlGenericControl("img");
                SongExplict.Attributes.Add("ID", "imageAblum");
                SongExplict.Attributes.Add("scr", toptracksResult.Tracks[i].Album.Images[0].Url);
                TopSongsContainer.Controls.Add(SongExplict);
            }


            popularContainer.Controls.Add(TopSongsContainer);
        }
    }
}