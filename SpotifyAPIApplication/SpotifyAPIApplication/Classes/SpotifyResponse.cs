using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using static SpotifyAPIApplication.Classes.ResArtist;

namespace SpotifyAPIApplication.Classes
{
    public class SpotifyResponse
    {
        public static string respAlbum(string albumID, SpotifyWebAPI _spotify, string link)
        {
            string url = string.Format(link + albumID);
            var webrequest = (HttpWebRequest)WebRequest.CreateHttp(url);
            webrequest.Method = "GET";
            webrequest.Headers.Add("Authorization", "Bearer " + _spotify.AccessToken);

            WebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();

            Stream responseStream = webresponse.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string result = reader.ReadToEnd();

            return result;
        }
    }
}