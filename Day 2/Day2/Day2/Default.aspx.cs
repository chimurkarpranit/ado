using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2
{
    public partial class _Default : Page
    {        
        StringBuilder sb1, sb2;
        string conString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
        public string SqlQuery1 { get; set; }
        public string SqlQuery2 { get; set; }
        protected void Page_Load(object sender, EventArgs e) //Page Load Method
        {
            if (!Page.IsPostBack)
            {
                BindGridView();
            }
        }
        protected void BindGridView()  // For Populating the GridView with Database
        {
            sb1 = new StringBuilder();
            //sb2 = new StringBuilder();
            try
            {                
                MySqlConnection con = new MySqlConnection(conString);
                sb1 = new StringBuilder(AllMessage.strEmp.ToString());
                sb2 = new StringBuilder(AllMessage.strTerr.ToString());
                SqlQuery1 = sb1.ToString();
                SqlQuery2 = sb1.ToString();
                MySqlDataAdapter sda1 = new MySqlDataAdapter(SqlQuery1, conString);
                MySqlDataAdapter sda2 = new MySqlDataAdapter(SqlQuery2, conString);
                DataSet ds = new DataSet();
                sda1.Fill(ds);
                sda2.Fill(ds);
                Session["DataSet"] = ds;
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)  // For Clicking on Page Number
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridView();
        }
    }
}