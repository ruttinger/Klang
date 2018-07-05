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

            AsyncContext.Run(() => MainAsync());

            string url = string.Format("https://api.spotify.com/v1/tracks/" + trackID);
            var webrequest = (HttpWebRequest)WebRequest.CreateHttp(url);
            webrequest.Method = "GET";
            webrequest.Headers.Add("Authorization", "Bearer " + _spotify.AccessToken);


            try
            {
                WebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();

                Stream responseStream = webresponse.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string result = reader.ReadToEnd();

                txtBox.Text = result;
                var artistResult = new JavaScriptSerializer().Deserialize<ResArtist.RootObject>(result);

                ////OUTPUT OF ELEMENTS
                txtBox.Text = artistResult.name;

            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)ex.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            string error = reader.ReadToEnd();
                        }
                    }
                }
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
            catch (Exception)
            {

            }

            if (_spotify == null)
                return;
        }
    }
}