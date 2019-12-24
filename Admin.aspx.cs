using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CURD
{
    public partial class Admin : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data source=.\\SQLEXPRESS_LOCAL; initial catalog=Demo; integrated security=True");
        DataTable dt;
        SqlDataAdapter sda;
        SqlCommand cmd;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Insert into [User] (UserId,Password) values(@UserId,@Password)", conn);
                cmd.Parameters.AddWithValue("@UserId", txtuser.Text.ToString());
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text.ToString());
                cmd.ExecuteNonQuery();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Data Save Successfully!');", true);
                conn.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser.aspx", false);
        }
    }
}