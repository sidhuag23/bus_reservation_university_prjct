using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bus_Reservation_System
{
    public partial class UserHome : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["BusReservationSystem"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("SELECT Id,CityName from City", con);
                    SqlCommand cmd1 = new SqlCommand("SELECT Id,CityName from City", con);
                    con.Open();
                    SqlDataReader city = cmd.ExecuteReader();
                   
                    From.DataSource = city;
                    From.DataBind();
                    
                    con.Close();
                    con.Open();
                    SqlDataReader city1 = cmd1.ExecuteReader();
                    To.DataSource = city1;
                    To.DataBind();
                    con.Close();
                }

            }
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT Count(Id) from Sheduling where BusFrom='"+From.Text+"'and BusTo='"+To.Text+ "'and cast( DepatureTime as date)='" + Date.Text +"'", con);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                if(count<1)
                {
                    string script = "alert(\"OOPS! Bus Not Available that location\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }
                else
                {
                    Session["From"] = From.Text;
                    Session["To"] = To.Text;
                    Session["Date"] = Date.Text;
                    Response.Redirect("~/UserBusDetails.aspx");
                }
                con.Close();
            }

        }
    }
}