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
        string prevSearch;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            
            //Switch to Search.aspx
            string currentSite = HttpContext.Current.Request.Url.AbsolutePath;
            if (currentSite != "~/Page/Search.aspx?search=" + prevSearch)
            {
                Response.Redirect("~/Page/Search.aspx?search=" + searchBar.Text);
            }
            prevSearch = searchBar.Text;
            searchBar.Visible = false;
        }
    }
}