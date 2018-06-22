using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpotifyAPIApplication
{
    public partial class Search : System.Web.UI.Page
    {
        TextBox searchTxt = new TextBox();

        public TextBox SearchTxt
        {
            get
            {
                return searchTxt;
            }

            set
            {
                searchTxt = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            searchRes.Text = searchTxt.Text;
        }
        
        
    }
}