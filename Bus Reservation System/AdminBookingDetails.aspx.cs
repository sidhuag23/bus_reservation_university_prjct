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
    public partial class AdminBookingDetails : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["BusReservationSystem"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                GetData();

            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("UPDATE BookingDeatils Set IsCancelled=1 Where Id='"+ id + "'", con);
                con.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Updated Successfully')", true);

                }
                
                con.Close();
                GetData();
            }
        }
        public void GetData()
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT * from BookingDeatils where IsPay=1 and IsDeleted=0", con);

                con.Open();
                SqlDataReader Customer = cmd.ExecuteReader();
                GridViewBookingDetails.DataSource = Customer;
                GridViewBookingDetails.DataBind();

                con.Close();

            }
        }
    }
}