using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class Index : System.Web.UI.Page
{
    string connectionString = @"Data Source=DESKTOP-IALMNF3;Initial Catalog=UserRegistrationDB;Integrated Security=True;";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Clear();
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                int userID = Convert.ToInt32(Request.QueryString["id"]);
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("UserViewByID", sqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@UserID", userID);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    hfUserID.Value = userID.ToString();
                    txtFirstName.Text = dtbl.Rows[0][1].ToString();
                    txtLastName.Text = dtbl.Rows[0][2].ToString();
                    txtContact.Text = dtbl.Rows[0][3].ToString();
                    ddlGender.Items.FindByValue(dtbl.Rows[0][4].ToString()).Selected = true;
                    txtAddress.Text = dtbl.Rows[0][5].ToString();
                    txtUsername.Text = dtbl.Rows[0][6].ToString();
                    txtPassword.Text = dtbl.Rows[0][7].ToString();
                    txtPassword.Attributes.Add("value", dtbl.Rows[0][7].ToString());
                    txtConfirmPassword.Text = dtbl.Rows[0][7].ToString();
                    txtConfirmPassword.Attributes.Add("value", dtbl.Rows[0][7].ToString());
                }
            }
        }
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtUsername.Text == "" || txtPassword.Text == "")
            lblErrorMessage.Text = "Please Fill the Mandatory Fields";
        else if (txtPassword.Text != txtConfirmPassword.Text)
            lblErrorMessage.Text = "Passwords do not Match";
        else
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                //.. we can write code to call the stored procedure
                //in c# using statements is a best practice to work with databases because we don't want to close 
                //the sql connection at the end of the statement and if there are errors the statement will close the conenctions
                SqlCommand sqlCmd = new SqlCommand("UserAddorEdit", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(hfUserID.Value == "" ? "0" : hfUserID.Value));
                sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);
                sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                sqlCmd.ExecuteNonQuery();
                Clear();
                lblSucessMessage.Text = "Submited Sucessfull";


            }
        }

        }
        void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtContact.Text = txtAddress.Text = txtUsername.Text = 
                txtPassword.Text = txtConfirmPassword.Text = "";
            lblSucessMessage.Text = lblErrorMessage.Text = "";
    }

}