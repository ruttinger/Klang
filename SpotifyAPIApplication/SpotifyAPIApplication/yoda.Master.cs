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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //Set Search-String to String in Search.aspx
            Search srch = new SpotifyAPIApplication.Search();
            srch.searchTxt = searchBar.Text;

            //Switch to Search.aspx
            string currentSite = HttpContext.Current.Request.Url.AbsolutePath;
            if (currentSite != "/Search.aspx")
            {
                Response.Redirect("~/Search.aspx");
            }

            searchBar.Visible = false;
        }
    }
}