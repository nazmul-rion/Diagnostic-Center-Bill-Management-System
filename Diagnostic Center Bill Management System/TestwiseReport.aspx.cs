using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diagnostic_Center_Bill_Management_System
{
    public partial class TeswiseReport : System.Web.UI.Page
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
            cmd = new MySqlCommand("SELECT test.Name AS `Test Name`, COUNT(testrequest.TestId) AS `Total Test`, test.Fee*COUNT(testrequest.TestId) AS `Total Ammount` FROM testrequest , test WHERE testrequest.TestId = test.Id AND testrequest.Date>=@fdate AND testrequest.Date<=@tdate  GROUP BY TestId ", con);
            cmd.Parameters.AddWithValue("@fdate", from);
            cmd.Parameters.AddWithValue("@tdate", to);
            con.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
    }
}