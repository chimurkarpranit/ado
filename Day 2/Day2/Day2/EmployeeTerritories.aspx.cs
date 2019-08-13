using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;

namespace Day2
{
    public partial class EmployeeTerritories : System.Web.UI.Page
    {
        string conString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindEmpTerr();
            }
        }
        protected void BindEmpTerr()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(AllMessage.strEmpTerr);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                cmd.Connection = con;
                sda.SelectCommand = cmd;
                DataSet ds = new DataSet();
                sda.Fill(ds);
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
            BindEmpTerr();
        }
    }
}