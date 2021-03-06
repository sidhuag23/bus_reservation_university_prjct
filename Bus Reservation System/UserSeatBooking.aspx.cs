using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bus_Reservation_System
{
    public partial class UserSeatBooking : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["BusReservationSystem"].ConnectionString;
        string SId="";
        string BId ="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                     SId = Session["sId"].ToString();
                     BId = Session["bId"].ToString();
                    SqlCommand cmd = new SqlCommand("Select t1.*,(SELECT	Id FROM Bus where Id=" + BId + ") BusNumber from seat t1", con);

                    con.Open();
                    SqlDataReader BusSeat = cmd.ExecuteReader();

                    DataList1.DataSource = BusSeat;
                    DataList1.DataBind();
                    con.Close();
                    SqlCommand cmd3 = new SqlCommand("Select SeatNumber from BookingDeatils where BusId='" + BId + "'and IsDeleted=0 and IsCancelled=0 and IsPay=1", con);
                    List<int> st = new List<int>();
                    con.Open();
                    SqlDataReader BookingDetails = cmd3.ExecuteReader();
                    while (BookingDetails.Read())
                    {
                        if (BookingDetails.GetValue(0) != null)
                        {
                            st.Add(Convert.ToInt32(BookingDetails.GetValue(0)));
                        }
                    }
                    foreach(int s in st)
                    {
                        for (int i = 0; i < 40; i++)
                        {
                            Button Seat1 = (Button)DataList1.Items[i].FindControl("ButtonSeat") as Button;
                            if(Seat1.Text==s.ToString())
                            {
                                Seat1.Enabled = false;
                                Seat1.BackColor = Color.Red;
                            }
                        }
                    }
                        
                    con.Close();
                    SqlCommand cmd2 = new SqlCommand("Select * from Sheduling where Id='" + SId + "'", con);
                    con.Open();
                    SqlDataReader SheduleDetails = cmd2.ExecuteReader();


                    while (SheduleDetails.Read())
                    { 
                    LabelFrom.Text = SheduleDetails.GetValue(2).ToString();
                    LabelTo.Text = SheduleDetails.GetValue(3).ToString();
                    LabelFromTime.Text = SheduleDetails.GetValue(4).ToString();
                    LabelToTime.Text = SheduleDetails.GetValue(5).ToString();
                    LabelStart.Text = SheduleDetails.GetValue(2).ToString();
                    LabelEnd.Text = SheduleDetails.GetValue(3).ToString();
                    }
                    con.Close();

                }

            }

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "st")
            {
                
                    //HiddenField hdn = (HiddenField)e.Item.FindControl("hdnfld1");

                    //    DataList1.ItemStyle.BackColor = Color.FromName("#A0FE96");
                    Button Seat = (Button)DataList1.Items[e.Item.ItemIndex].FindControl("ButtonSeat") as Button;
                    var a = Seat.Text;

                if (Seat.BackColor == Color.Green)
                {
                    Seat.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    Seat.BackColor = Color.Green;
                }
                var rate = 0;
                var seats = "";
                int n = 0;
                for(int i=0;i<40;i++)
                {
                    Button Seat1 = (Button)DataList1.Items[i].FindControl("ButtonSeat") as Button;
                    if(Seat1.BackColor== Color.Green)
                    {
                        rate = rate + 100;
                        if (n == 0)
                        {
                            seats = Seat1.Text;
                            n = 1;
                        }
                        else
                        {
                            seats = seats + "," + Seat1.Text;
                        }
                    }
                }
                LabelAmount.Text = rate.ToString();
                LabelSeats.Text = seats;




            }
        }

        protected void ButtonBook_Click(object sender, EventArgs e)
        {
            if(LabelAmount.Text!="" && LabelSeats.Text!="")
            {
                Session["sId"] = Session["sId"].ToString();
                Session["bId"] = Session["bId"].ToString();
                Session["Amount"] = LabelAmount.Text;
                Session["Seats"] = LabelSeats.Text;
                Response.Redirect("~/UserCustomerDeatils.aspx");
            }
            else
            {
                
            }
        }
    }
}