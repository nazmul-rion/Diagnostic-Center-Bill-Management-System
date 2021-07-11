using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diagnostic_Center_Bill_Management_System
{
    public partial class UnpaidBill : System.Web.UI.Page
    {

        MySqlConnection con = new MySqlConnection("server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =web_assignment; SslMode = none");
        MySqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string from = Request.Form.Get("fdate");
            string to = Request.Form.Get("tdate");
            cmd = new MySqlCommand("SELECT BillNo, Mobile, TotalFee, DueDate FROM payment WHERE DueDate>=@fdate AND DueDate<=@tdate", con);
            cmd.Parameters.AddWithValue("@fdate", from);
            cmd.Parameters.AddWithValue("@tdate", to);
            con.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
    }
}