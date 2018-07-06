using Nito.AsyncEx;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpotifyAPIApplication
{
    public partial class Default : System.Web.UI.Page
    {
        public static SpotifyWebAPI _spotify;
        protected void Page_Load(object sender, EventArgs e)
        {
            AsyncContext.Run(() => MainAsync());
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