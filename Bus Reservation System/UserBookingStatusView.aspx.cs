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
    public partial class UserBookingStatusView : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["BusReservationSystem"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var BkId = Session["BId"].ToString();

                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("select Name,SeatNumber,IsCancelled, s.BusFrom,s.BusTo,s.DepatureTime,s.ArrivalTime,s.Rate from BookingDeatils as bd inner join Sheduling as s on bd.SheduleId=s.Id where bd.Id='" + BkId + "'", con);
                    con.Open();
                    SqlDataReader SheduleDetails = cmd.ExecuteReader();


                    while (SheduleDetails.Read())
                    {

                        LabelBkId.Text = BkId;
                        LabelName.Text= SheduleDetails.GetValue(0).ToString();
                        LabelStNo.Text= SheduleDetails.GetValue(1).ToString();
                        LabelFrom.Text= SheduleDetails.GetValue(3).ToString();
                        LabelTo.Text= SheduleDetails.GetValue(4).ToString();
                        LabelDTime.Text= SheduleDetails.GetValue(5).ToString();
                        LabelATime.Text= SheduleDetails.GetValue(6).ToString();
                        LabelRate.Text= SheduleDetails.GetValue(7).ToString();
                    }
                    con.Close();
                }

            }
        }

        protected void ButtonCancelBooking_Click(object sender, EventArgs e)
        {
            var BkId = Session["BId"].ToString();
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("UPDATE BookingDeatils Set IsCancelled=1 Where Id='" + BkId + "'", con);
                con.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Booking Canceled Successfully')", true);

                }

                con.Close();
                Response.Redirect("UserHome.aspx");
            }
        }
    }
}