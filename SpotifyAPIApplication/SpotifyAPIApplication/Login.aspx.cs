using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace SpotifyAPIApplication
{
    public partial class Login : System.Web.UI.Page
    {
        string connString = "Data Source=(LocalDB)/MSSQLLocalDB;AttachDbFilename=C:/Users\rafael.uttinger/Source/Repos/Klang/SpotifyAPIApplication/SpotifyAPIApplication/App_Data/KlangDB.mdf;Integrated Security = True";
        SqlConnection connection = new SqlConnection();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            connection.ConnectionString = connString;

            DataTable dtUser = connection.GetSchema("tblUser");
            for (int i = 0; i < dtUser.Rows.Count; i++)
            {
                if(txtUser == dtUser.Rows[i]["Username"])
                {
                    if(txtPw == dtUser.Rows[i]["Password"])
                    {
                        lblOutput.Text = "successfull login";
                        break;
                    }
                }
            }
            if (lblOutput.Text == null)
            {
                lblOutput.Text = "failed login";
            }
            connection.Close();
        }

    }
}