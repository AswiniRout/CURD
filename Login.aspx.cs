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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data source=.\\SQLEXPRESS_LOCAL; initial catalog=Demo; integrated security=True");
        DataTable dt;
        DataSet ds;
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                sda = new SqlDataAdapter("select * from [User] where UserId='"+txtUserid.Text.ToString()+"' and Password='"+txtUserPass.Text.ToString()+"'", conn);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {    
                        Response.Redirect("Admin.aspx",false);
                }
                else
                {
                    lblMsg.Text = "Invalid User or Password";
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }
    }
}