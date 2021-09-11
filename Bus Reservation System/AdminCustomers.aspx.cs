using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bus_Reservation_System
{
    public partial class AdminCustomers : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["BusReservationSystem"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("SELECT Id,UserId,Name,PhoneNumber from Users where IsAdmin=0", con);
                   
                    con.Open();
                    SqlDataReader Customer = cmd.ExecuteReader();
                    GridViewCustomer.DataSource = Customer;
                    GridViewCustomer.DataBind();

                    con.Close();
                   
                }

            }
        }

        protected void DeleteUser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);
        }
    }
}