using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diagnostic_Center_Bill_Management_System
{
    public partial class Payment : System.Web.UI.Page
    {

        MySqlConnection con = new MySqlConnection("server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =web_assignment; SslMode = none");
        MySqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string billno = Request.Form.Get("billno");
            string mob = Request.Form.Get("mobile");
            cmd = new MySqlCommand("SELECT * FROM payment WHERE BillNo = @bno OR Mobile = @mob AND Ispaid = @paid ", con);
            cmd.Parameters.AddWithValue("@bno", billno);
            cmd.Parameters.AddWithValue("@mob", mob);
            cmd.Parameters.AddWithValue("@paid", "false");
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string fees = reader["TotalFee"].ToString();
                string due = reader["DueDate"].ToString();
                ammount.Value = fees;
                duedate.Value = due;
            }         
            con.Close();
           
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            string billno = Request.Form.Get("billno");
            string mob = Request.Form.Get("mobile");

            cmd = new MySqlCommand("delete from payment where BillNo =@bno OR Mobile = @mob ", con);
            cmd.Parameters.AddWithValue("@bno", billno);
            cmd.Parameters.AddWithValue("@mob", mob);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}