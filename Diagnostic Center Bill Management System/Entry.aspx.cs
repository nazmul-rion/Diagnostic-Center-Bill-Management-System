using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diagnostic_Center_Bill_Management_System
{
    public partial class Entry : System.Web.UI.Page
    {

        MySqlConnection con = new MySqlConnection("server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =web_assignment; SslMode = none");
        MySqlCommand cmd;
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!Page.IsPostBack)
            {
                filldropdown();
                if (ViewState["Records"] == null)
                {
                    dt.Columns.Add("Test ID");
                    dt.Columns.Add("Test Name");
                    dt.Columns.Add("Fee");
                    ViewState["Records"] = dt;
                }
            }

        }

        private void filldropdown()
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM test"))
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
        protected void addbtn_Click(object sender, EventArgs e)
        {
            
            dt = (DataTable)ViewState["Records"];
            dt.Rows.Add(DropDownList1.SelectedValue, DropDownList1.SelectedItem, fee.Value);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            double sum = 0;
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                sum += Double.Parse(GridView1.Rows[i].Cells[2].Text);
            }
            total.Value = sum.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string testid = DropDownList1.SelectedValue;
            cmd = new MySqlCommand("SELECT Fee FROM test where Id = @tid", con);
            cmd.Parameters.AddWithValue("@tid", testid);
                con.Open();
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                string fees = data["Fee"].ToString();
                
                fee.Value = fees;

            }


            con.Close();
            

        }

        protected void savebtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            string pname = Request.Form.Get("pname");
            var randomNumber = rnd.Next(1000, 10000);
            string bill = randomNumber.ToString();
            string mob = Request.Form.Get("mobile");
            string totalfee = total.Value;
            string duedate = DateTime.Now.ToString("yyyy-MM-dd");          

            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                string tid = GridView1.Rows[i].Cells[0].Text;

                cmd = new MySqlCommand("insert into testrequest (BillNo, TestId , PatientName, Date) values (@bill,@tid,@pid,@date)", con);
                cmd.Parameters.AddWithValue("@bill", bill);
                cmd.Parameters.AddWithValue("@tid", tid);
                cmd.Parameters.AddWithValue("@pid", pname);
                cmd.Parameters.AddWithValue("@date", duedate);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            cmd = new MySqlCommand("insert into payment (`BillNo`,`Mobile`, `TotalFee`, `DueDate`, `IsPaid`) values (@bill,@mob,@tfee,@ddate,@paid)", con);
                cmd.Parameters.AddWithValue("@bill", bill);
                cmd.Parameters.AddWithValue("@mob", mob);
                cmd.Parameters.AddWithValue("@tfee", totalfee);
                cmd.Parameters.AddWithValue("@ddate", duedate);
                cmd.Parameters.AddWithValue("@paid", "false");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();        

        }
    }
}