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
    public partial class AdminSheduling : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["BusReservationSystem"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                GetData();
            }
        }
        public void GetData()
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT Id,BusNumber,BusFrom,BusTo,DepatureTime,ArrivalTime,Rate from Sheduling ", con);

                con.Open();
                SqlDataReader Bus = cmd.ExecuteReader();
                GridViewShedule.DataSource = Bus;
                GridViewShedule.DataBind();

                con.Close();

            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Session["Id"] = "";
            Response.Redirect("AdminShedulingAddorEdit.aspx");
        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);
            Session["Id"] = id.ToString();
            Response.Redirect("AdminShedulingAddorEdit.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Delete from Sheduling where Id='" + id + "'", con);
                con.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Deleted Successfully')", true);

                }
                con.Close();
                GetData();
            }
        }
    }
}