using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

namespace Diagnostic_Center_Bill_Management_System
{
    public partial class TestType : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection("server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =web_assignment; SslMode = none");
        MySqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            showtable();
        }

        private void showtable()
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM testtype"))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                con.Close();
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string Tname = Request.Form.Get("Type_Name");
            
            try
            {
                cmd = new MySqlCommand("insert into testtype (Name) values (@tname)", con);
                cmd.Parameters.AddWithValue("@tname", Tname);
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