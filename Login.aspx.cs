using System;
using System.Data;
using System.Data.SqlClient;

namespace CURD
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data source=.\\SQLEXPRESS_LOCAL; initial catalog=Demo; integrated security=True");
        DataTable dt;
        SqlDataAdapter sda;
        //private static int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {

            }
        }
        //public bool CheckEmp(String Userid, String Email)
        //{

        //    con = new SqlConnection(constr);
        //    con.Open();
        //    SqlDataAdapter sda = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    SqlCommand cmd = new SqlCommand("SELECT * FROM USERDTL where USER_ID= '" + Userid + "' and [E_MAIL]= '" + Email + "'", con);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con;
        //    sda.SelectCommand = cmd;
        //    sda.Fill(dt);
        //    con.Close();
        //    if (dt.Rows.Count > 0)
        //    {

        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }


        //}
        //protected void btnLogin_Click(object sender, EventArgs e)
        //{
        //    con = new SqlConnection(constr);
        //    try
        //    {
        //        SqlDataAdapter sda = new SqlDataAdapter();
        //        dt = new DataTable();
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM USERDTL where USER_ID='" + txtUser.Text.ToString() + "' and PASSWORD='" + Encrypt(txtPass.Text.Trim()) + "'", con);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = con;
                
        //        sda.SelectCommand = cmd;
        //        sda.Fill(dt);              
        //        if (dt.Rows.Count > 0)
        //        {
        //            Session["User"] = dt.Rows[0]["USER_ID"].ToString();
        //            Session["UserName"] = dt.Rows[0]["USER_NAME"].ToString();
        //            Session["UserType"] = dt.Rows[0]["TYPE_ID"].ToString();
        //            Session["Photo"]= dt.Rows[0]["USER_PHOTO"].ToString();
        //            Session["Designation"] = dt.Rows[0]["DESIGNATION"].ToString();
        //            Session["DOJ"] = dt.Rows[0]["DOJ"].ToString();
        //            Session["MOB"] = dt.Rows[0]["PHONE_NO"].ToString();
        //            Session["Email"] = dt.Rows[0]["E_MAIL"].ToString();
        //            if (dt.Rows[0]["ACTIVE_STS"].ToString() == "1")   //Check User Status
        //            {
        //                count = 0;
        //                if (dt.Rows[0]["TYPE_ID"].ToString() == "1")  // Admin
        //                {
        //                    Response.Redirect("admin.aspx", false);
        //                }
        //                if (dt.Rows[0]["TYPE_ID"].ToString() == "2")   // HR
        //                {
        //                    Response.Redirect("HRDashboard.aspx", false);
        //                }
        //                if (dt.Rows[0]["TYPE_ID"].ToString() == "3")   // Manager
        //                {
        //                    Response.Redirect("ManagerDashboard.aspx", false);
        //                }
        //                if (dt.Rows[0]["TYPE_ID"].ToString() == "4") // Employee
        //                {
        //                    Response.Redirect("EmployeeDashboard.aspx", false);
        //                }

        //            }
        //            else
        //            {

        //                lblFailLogCount.Text = "Inactive User,Please contact system Administrator. ";
        //            }
        //        }
        //        else
        //        {
        //            InvalidLogin();
                      
        //            //ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Invalid Userid or Password');", true);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //private void InvalidLogin()
        //{
            
        //    try
        //    {
        //        count++;
        //        lblFailLogCount.Text = "Invalid login attemp :" + count + ",  Remaining : " + Convert.ToInt32(3 - count).ToString();
        //        if (count > 3)
        //        {
                    
        //            con = new SqlConnection(constr);
        //            SqlCommand cmd = new SqlCommand("PROC_UPDATE", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@UserId", txtUser.Text.ToString());
                    
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //            lblFailLogCount.Text = "Your Account has been blocked, Please Contact System Administrator.";

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //protected void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!CheckEmp(txtUser.Text.ToString(), txtEmail.Text.ToString()))
        //        {

        //            con.Open();
        //            SqlDataAdapter sda = new SqlDataAdapter();
        //            dt = new DataTable();
        //            SqlCommand cmd = new SqlCommand("SELECT * FROM USERDTL where USER_ID='" + txtUserId.Text.ToString() + "' ", con);
        //            cmd.CommandType = CommandType.Text;
        //            cmd.Connection = con;
        //            sda.SelectCommand = cmd;
        //            sda.Fill(dt);
        //            string name = dt.Rows[0]["USER_NAME"].ToString();
        //            string userid = dt.Rows[0]["USER_ID"].ToString();
        //            string pass = dt.Rows[0]["PASSWORD"].ToString();
        //            string mesg = "Dear '" + name + "' your User Id is : '" + userid + "' and Password is : '" + pass + "'";

        //            Execute(txtEmail.Text.ToString(), mesg);
        //            con.Close();
        //        }

        //        else
        //        {
        //            lblMsg.Text = "User do not Exist";
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}
        ////Send Email   Note use Send grid in namesapase for email (using SendGrid.Helpers.Mail; using SendGrid;)
        //static async void Execute(string Email, string Msg)
        //{
        //    var apiKey = Environment.GetEnvironmentVariable("NAME_OF_THE_ENVIRONMENT_VARIABLE_FOR_YOUR_SENDGRID_KEY");
        //    var client = new SendGridClient("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");
        //    var from = new EmailAddress("soumya4525@gmail.com", "E-Control");
        //    var subject = "Forgot Password";
        //    var to = new EmailAddress(Email, "Forgot Password");
        //    var plainTextContent = "Forgot Password";
        //    var htmlContent = Msg;
        //    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        //    var response = await client.SendEmailAsync(msg);
        //}
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
