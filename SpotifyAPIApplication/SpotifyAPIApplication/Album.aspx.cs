using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SpotifyAPIApplication
{
    public partial class Album : System.Web.UI.Page
    {
        public FullAlbum faAlbum;
        protected void Page_Load(object sender, EventArgs e)
        {
            faAlbum = new FullAlbum();
            faAlbum.Id = Request.QueryString["album"];
        }
    }
}