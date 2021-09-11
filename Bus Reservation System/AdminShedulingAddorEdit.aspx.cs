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
    public partial class AdminShedulingAddorEdit : System.Web.UI.Page
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
                    SqlCommand cmd2 = new SqlCommand("SELECT Id,BusNumber from Bus", con);

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
                    con.Open();
                    SqlDataReader Bus = cmd2.ExecuteReader();
                    DropDownListBusNumber.DataSource = Bus;
                    DropDownListBusNumber.DataBind();
                    con.Close();
                }
                var Id = Session["Id"].ToString();
                if (Id == "")
                {
                    LabelAddorEdit.Text = "Add ";
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlCommand cmd = new SqlCommand("Select BusNumber,BusFrom,BusTo,DepatureTime,ArrivalTime,Rate from Sheduling where Id='" + Id + "'", con);
                        con.Open();
                        SqlDataReader SheduleDetails = cmd.ExecuteReader();


                        while (SheduleDetails.Read())
                        {
                            DropDownListBusNumber.SelectedValue= SheduleDetails.GetValue(0).ToString();
                            DropDownListFrom.SelectedValue= SheduleDetails.GetValue(1).ToString();
                            DropDownListTo.SelectedValue= SheduleDetails.GetValue(2).ToString();
                            TextBoxDepatureTime.Text = SheduleDetails.GetValue(3).ToString();
                            TextBoxArrivalTime.Text = SheduleDetails.GetValue(4).ToString();
                            TextBoxRate.Text = SheduleDetails.GetValue(5).ToString();
                        }
                        con.Close();
                    }
                }
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                var Number = DropDownListBusNumber.SelectedValue;
                var From = DropDownListFrom.SelectedValue;
                var To = DropDownListTo.SelectedValue;
                var DTime = TextBoxDepatureTime.Text;
                var ATime = TextBoxArrivalTime.Text;
                var Rate = TextBoxRate.Text;
                var Id = Session["Id"].ToString();
                if (Id == "")
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Sheduling (BusNumber,BusFrom, BusTo,DepatureTime,ArrivalTime,Rate)VALUES ('" + Number + "','" + From + "','" + To + "','" + DTime + "','" + ATime + "','" + Rate + "')", con);
                    con.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);

                    }
                    Response.Redirect("AdminSheduling.aspx");
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Sheduling Set BusNumber='" + Number + "',BusFrom='" + From + "', BusTo='" + To + "',DepatureTime='" + DTime + "',ArrivalTime='" + ATime + "',Rate='" + Rate + "' where Id='" + Id + "'", con);
                    con.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Updated Successfully')", true);

                    }
                    Response.Redirect("AdminSheduling.aspx");
                    con.Close();
                }
            }
        }
    }
}