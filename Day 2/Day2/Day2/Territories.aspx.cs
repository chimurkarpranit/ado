using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2
{
    public partial class Territories : Page
    {
        string conString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
        protected void Page_Load(object sender, EventArgs e) //Page Load Method
        {
            if (!Page.IsPostBack)
            {
                BindGridView();
            }
        }
        protected void BindGridView()  // For Populating the GridView with Database
        {
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(AllMessage.strTerr);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            DataTable ds = new DataTable();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)  // For Clicking on Page Number
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridView();
        }
    }
}