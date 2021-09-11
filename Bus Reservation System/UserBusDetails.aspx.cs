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
    public partial class UserBusDetails : System.Web.UI.Page
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

                    DropDownListFrom.DataSource = city;
                    DropDownListFrom.DataBind();

                    con.Close();
                    con.Open();
                    SqlDataReader city1 = cmd1.ExecuteReader();
                    DropDownListTo.DataSource = city1;
                    DropDownListTo.DataBind();
                    con.Close();
                }

           
            using (SqlConnection con = new SqlConnection(CS))
            {
                var From = Session["From"].ToString();
                var To = Session["To"].ToString();
                var Date = Session["Date"].ToString();
               // SqlCommand cmd = new SqlCommand("SELECT * from Sheduling where BusFrom='" + From + "'and BusTo='" + To + "'and cast( DepatureTime as date)='" + Date + "'", con);
                SqlCommand cmd = new SqlCommand("select  s.Id as shId,b.Id as bsId, s.BusNumber,BusFrom,BusTo,FORMAT(DepatureTime, 'yyyy-MM-dd hh:mm') as DepatureTime,FORMAT(ArrivalTime, 'yyyy-MM-dd hh:mm') as ArrivalTime,CONVERT(varchar(5), DATEADD(minute, DATEDIFF(minute, DepatureTime, ArrivalTime), 0), 114) as duration, Rate,b.BusType,b.BusName from sheduling as s  inner join bus as b on s.BusNumber = b.BusNumber where BusFrom ='" + From + "'and BusTo='" + To + "'and cast( DepatureTime as date)='" + Date + "'", con);
                con.Open();
                SqlDataReader Shedule = cmd.ExecuteReader();
                DataList1.DataSource = Shedule;
                DataList1.DataBind();
                con.Close();
            }
            }

        }
       

        
        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                var From = DropDownListFrom.Text;
                var To = DropDownListTo.Text;
                var Date = TextBoxDate.Text;
                SqlCommand cmd = new SqlCommand("select s.BusNumber,BusFrom,BusTo,FORMAT(DepatureTime, 'yyyy-MM-dd hh:mm'),FORMAT(ArrivalTime, 'yyyy-MM-dd hh:mm'),CONVERT(varchar(5), DATEADD(minute, DATEDIFF(minute, DepatureTime, ArrivalTime), 0), 114) as duration, Rate,b.BusType, s.Id as shId,b.Id as bsId,b.BusName from sheduling as s  inner join bus as b on s.BusNumber = b.BusNumber where BusFrom ='" + From + "'and BusTo='" + To + "'and cast( DepatureTime as date)='" + Date + "'", con);
                con.Open();
                SqlDataReader Shedule = cmd.ExecuteReader();
                DataList1.DataSource = Shedule;
                DataList1.DataBind();
                con.Close();
            }
        }
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "ViewSeats")
            {
                Label sId= (Label)DataList1.Items[e.Item.ItemIndex].FindControl("LabelSheduleId") as Label;
               Label bId = (Label)DataList1.Items[e.Item.ItemIndex].FindControl("LabelBusId") as Label;
                Session["sId"] = sId.Text;
                Session["bId"] = bId.Text;
                Response.Redirect("UserSeatBooking.aspx");
            }

        }

    }
}