using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace Bus_Reservation_System
{
    public partial class UserPayment : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["BusReservationSystem"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            ButtonPay.Text = "Pay INR :" + Session["Amt"].ToString() ;
        }

        protected void ButtonPay_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
             
                
                

                
                var BusId = Session["BusId"].ToString();
                var StNo = Session["SeatNumberString"].ToString();
                List<int> SeatList = StNo.Split(',').Select(int.Parse).ToList();
                int TotalAmount = 0;
                var TkNo = "";
                foreach (int s in SeatList)
                {
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("UPDATE BookingDeatils SET IsPay = 1 WHERE BusId = '" + BusId + "'and SeatNumber='" + s.ToString() + "' and IsDeleted=0 and IsCancelled=0", con);
                    int Rowaffected = cmd2.ExecuteNonQuery();
                    con.Close();
                    con.Open();

                    SqlCommand cmd3 = new SqlCommand("select bd.Id,BusId,SeatNumber,Name,BusNumber,BusFrom,BusTo,DepatureTime,ArrivalTime,rate from BookingDeatils as bd inner join Sheduling as s on bd.SheduleId=s.Id where SeatNumber='" + s.ToString() + "' and IsDeleted=0 and IsCancelled=0 and IsPay=1  ", con);
                    SqlDataReader Alldetails = cmd3.ExecuteReader();


                    while (Alldetails.Read())
                    {
                        //TotalAmount = TotalAmount+Convert.ToInt32( Alldetails.GetValue(9).ToString());
                        LabelFrom.Text = Alldetails.GetValue(5).ToString();
                        LabelName2.Text = Alldetails.GetValue(3).ToString();
                        LabelFrom2.Text = Alldetails.GetValue(5).ToString();
                        LabelTo2.Text = Alldetails.GetValue(6).ToString();
                        LabelTo.Text = Alldetails.GetValue(6).ToString();
                        LabelBusId.Text = Alldetails.GetValue(1).ToString();
                        LabelDTime.Text = Alldetails.GetValue(7).ToString();
                        LabelATime.Text = Alldetails.GetValue(8).ToString();
                        LabelStNo.Text = StNo;
                        TkNo = TkNo+","+ Alldetails.GetValue(0).ToString();
                        LabelAmount.Text = TotalAmount.ToString();


                    }
                    con.Close();
                }
                LabelTicketNo.Text = TkNo;




                Panel1.Visible = true;
                ScriptManager.RegisterStartupScript(this, GetType(), "Pay", "printpage()", true);
                
            }
        }
    }
}