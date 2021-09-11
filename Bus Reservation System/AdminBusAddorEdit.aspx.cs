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
    public partial class AdminBusAddorEdit : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["BusReservationSystem"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var Id = Session["Id"].ToString();
                if (Id == "")
                {
                    LabelAddorEdit.Text = "Add ";
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(CS))
                    { 
                    SqlCommand cmd = new SqlCommand("Select BusNumber,BusName,BusType from Bus where Id='" + Id + "'", con);
                    con.Open();
                    SqlDataReader SheduleDetails = cmd.ExecuteReader();


                    while (SheduleDetails.Read())
                    {
                        TextBoxBusNumber.Text = SheduleDetails.GetValue(0).ToString();
                            TextBoxBusName.Text = SheduleDetails.GetValue(1).ToString();
                            TextBoxType.Text = SheduleDetails.GetValue(2).ToString();
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
                var Number = TextBoxBusNumber.Text;
                var Name = TextBoxBusName.Text;
                var Type = TextBoxType.Text;
                var Id = Session["Id"].ToString();
                if (Id == "")
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Bus (BusNumber,BusName, BusType)VALUES ('" + Number + "','" + Name + "','" + Type + "')", con);
                    con.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);

                    }
                    Response.Redirect("AdminBuses.aspx");
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Bus Set BusNumber='"+ Number + "',BusName='"+ Name + "', BusType='"+ Type + "' where Id='"+Id+"'", con);
                    con.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Updated Successfully')", true);

                    }
                    Response.Redirect("AdminBuses.aspx");
                    con.Close();
                }
            }
        }
    }
}