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
    public partial class ViewUser : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data source=.\\SQLEXPRESS_LOCAL; Initial Catalog=Demo; Integrated Security=True;");
        DataTable dt;
        DataSet ds;
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                BindGrid();
            }
        }
        public void BindGrid()
        {
            dt = new DataTable();
            sda = new SqlDataAdapter("Select * from [User]", conn);
            sda.Fill(dt);
            if(dt.Rows.Count>0)
            {
                GridUser.DataSource = dt;
                GridUser.DataBind();
            }
            else
            {
                GridUser.DataSource = null;
                GridUser.EmptyDataText = "Data Not Found";
                
            }
        }
    }
}