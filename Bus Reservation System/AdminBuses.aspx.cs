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
    public partial class AdminBuses : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["BusReservationSystem"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                GetData();
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Session["Id"] = "";
            Response.Redirect("AdminBusAddorEdit.aspx");
        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);
            Session["Id"] = id.ToString();
            Response.Redirect("AdminBusAddorEdit.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Delete from Bus where Id='"+id+"'", con);
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
        public void GetData()
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT Id,BusNumber,BusName,BusType from Bus ", con);

                con.Open();
                SqlDataReader Bus = cmd.ExecuteReader();
                GridViewBus.DataSource = Bus;
                GridViewBus.DataBind();

                con.Close();

            }
        }
    }
}