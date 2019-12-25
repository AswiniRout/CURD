using System;
using System.Data;              //For Data Set and Data Table
using System.Data.SqlClient;   // For SqlDataAdapter & SqlConnection

namespace CURD
{
    public partial class ViewUser : System.Web.UI.Page
    {
        // Object Creation for SqlConnection  Data Source= Server Name ; Initial Catalog= Data Base Name; Integrated Security=True (Used for Windows Authentication in SQL Server)
        SqlConnection conn = new SqlConnection("Data source=.\\SQLEXPRESS_LOCAL; Initial Catalog=Demo; Integrated Security=True;");
        DataTable dt;       // For Returning Single Tables
        DataSet ds;        // For Returning Multiple ables
        SqlDataAdapter sda; //  Retrive Data from Data Source
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                BindGrid();  // Method calling For displaying Data in GridView at Page loading
            }
        }

        //Method For Data Bind in GridView
        public void BindGrid()
        {
            dt = new DataTable();
            sda = new SqlDataAdapter("Select * from [User]", conn); // SQL Query to retrive Data from User Table
            sda.Fill(dt);                                         // Set Data into Data Table
            if(dt.Rows.Count>0)                                // Check whether a single record exist in Data Table or not
            {
                GridUser.DataSource = dt;                    // Assigning Data Table to Gridview
                GridUser.DataBind();                         //To read the data from the data source                  
            }
            else
            {
                GridUser.DataSource = null;
                GridUser.EmptyDataText = "Data Not Found";
                
            }
        }
    }
}