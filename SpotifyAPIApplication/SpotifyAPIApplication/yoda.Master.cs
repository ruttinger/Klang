using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpotifyAPIApplication
{
    public partial class yoda : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnPlaylist_Click(object sender, EventArgs e)
        {
            //Switch to Playlist.aspx
            string currentSite = HttpContext.Current.Request.Url.AbsolutePath;
            if (currentSite != "/Playlist.aspx")
            {
                Server.Transfer("~/Playlist.aspx", true);
            }    
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //Set Search-String to TextBox in Search.aspx
            Search srch = new SpotifyAPIApplication.Search();
            srch.SearchTxt.Text = searchBar.Text;

            //Switch to Search.aspx
            string currentSite = HttpContext.Current.Request.Url.AbsolutePath;
            if (currentSite != "/Search.aspx")
            {
                Server.Transfer("~/Search.aspx", true);
            }
        }
    }
}