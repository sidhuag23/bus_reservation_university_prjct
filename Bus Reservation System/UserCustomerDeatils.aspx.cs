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
    public partial class UserCustomerDeatils : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["BusReservationSystem"].ConnectionString;
        string SId = "";
        string BId = "";
        string Amt = "";
        string Sts = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SId = Session["sId"].ToString();
                    BId = Session["bId"].ToString();
                    Amt=Session["Amount"].ToString();
                    Sts=Session["Seats"].ToString();
                    
                    SqlCommand cmd2 = new SqlCommand("Select * from Sheduling where Id='" + SId + "'", con);
                    con.Open();
                    SqlDataReader SheduleDetails = cmd2.ExecuteReader();


                    while (SheduleDetails.Read())
                    {
                        LabelFrom.Text = SheduleDetails.GetValue(2).ToString();
                        LabelTo.Text = SheduleDetails.GetValue(3).ToString();
                        LabelAmount.Text = Amt;
                    }
                    con.Close();

                }

            }
        }

        protected void ButtonPay_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                var UserId = "";
                var SheduleId = Session["sId"].ToString();
                var BusId = Session["bId"].ToString();
                var SeatNumberString = Session["Seats"].ToString();
                var Name =TextBoxName.Text;
                var Age = TextBoxAge.Text;
                
                var Gender = "";
                if(RadioButtonMale.Checked)
                {
                    Gender = RadioButtonMale.Text;
                }
                else
                {
                    Gender = RadioButtonFemale.Text;
                }
                var PhoneNumber = TextBoxPhone.Text;
                var Mail = TextBoxMail.Text;
                int GetId = 0;
                List<int> SeatList = SeatNumberString.Split(',').Select(int.Parse).ToList();
                foreach (int s in SeatList)
                {
                    var SeatNumber = s.ToString();
                    SqlCommand cmd = new SqlCommand("INSERT INTO BookingDeatils (UserId,SheduleId, BusId,SeatNumber,Name,Age,Gender,PhoneNumber,Mail)VALUES ('"+ UserId + "','"+ SheduleId + "','"+ BusId + "','"+ SeatNumber + "','"+ Name + "','"+ Age + "','"+ Gender + "','"+ PhoneNumber + "','"+ Mail + "');SELECT SCOPE_IDENTITY() ", con);
                    GetId = Convert.ToInt32(cmd.ExecuteScalar());
                }
                if(GetId > 0)
                {
                    Session["Amt"]= Session["Amount"].ToString();
                    Session["BusId"] = BusId;
                    Session["SeatNumberString"] = SeatNumberString;
                    Response.Redirect("~/UserPayment.aspx");
                }
                

                con.Close();
            }
        }
    }
}