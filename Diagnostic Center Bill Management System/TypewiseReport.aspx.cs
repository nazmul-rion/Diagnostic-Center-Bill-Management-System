using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diagnostic_Center_Bill_Management_System
{
    public partial class TypewiseReport : System.Web.UI.Page
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
            cmd = new MySqlCommand("SELECT DISTINCT testtype.Name AS `Test Type Name`, COUNT( testtype.Name) AS `Total Test`, test.Fee*COUNT(testtype.Name) AS `Total Ammount` FROM testrequest , test, testtype WHERE testtype.Id = test.TypeId  AND testrequest.TestId = test.Id AND testrequest.Date>=@fdate AND testrequest.Date<=@tdate  GROUP BY testtype.Name ", con);
            cmd.Parameters.AddWithValue("@fdate", from);
            cmd.Parameters.AddWithValue("@tdate", to);
            con.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
    }
}