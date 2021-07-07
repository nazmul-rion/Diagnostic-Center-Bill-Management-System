using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace Diagnostic_Center_Bill_Management_System
{

    public partial class TestSetup : System.Web.UI.Page
    {

        MySqlConnection con = new MySqlConnection("server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =web_assignment; SslMode = none");
        MySqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            filldropdown();
            showtable();
        }

        private void showtable()
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM test"))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                con.Close();
            }
        }

        private void filldropdown()
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM testtype"))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                con.Open();
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();
                con.Close();
            }
            
        }
       
        protected void savebtn(object sender, EventArgs e)
        {

            string testname = Request.Form.Get("testname");
            string fee = Request.Form.Get("fee");
            string tid = DropDownList1.SelectedValue;
          
            try
            {
                cmd = new MySqlCommand("insert into `test`(`Name`,`Fee`,`TypeId`) values(@tname,@fee,@tid)", con);
                cmd.Parameters.AddWithValue("@tname", testname);
                cmd.Parameters.AddWithValue("@fee", fee);
                cmd.Parameters.AddWithValue("@tid", tid);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
                con.Close();
                return;
            }

        }
    }
}