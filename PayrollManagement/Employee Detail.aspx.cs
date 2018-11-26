using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace PayrollManagement
{
    public partial class Employee_Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEmpId.Text))
            {
                String source = @"Data Source=GAMEFREAK;Initial Catalog=Software_ProjectDB;Integrated Security=True";
                SqlConnection conn = new SqlConnection(source);

                conn.Open();
                String queryDisplay = "SELECT * FROM Employee WHERE EmployeeID = " + int.Parse(txtEmpId.Text);
                SqlCommand cmd = new SqlCommand(queryDisplay, conn);
                SqlDataReader mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    txtFname.Text = mdr["firstName"].ToString();
                    txtLname.Text = mdr["lastName"].ToString();
                    txtPhone.Text = mdr["phoneNumber"].ToString();
                    txtEmail.Text = mdr["email"].ToString();
                    lblSSN.Visible = true;
                    lblSSN.Text = mdr["socialNumber"].ToString();
                    txtAdd1.Text = mdr["address"].ToString();
                }
                conn.Close();

            }
            else
            {
                lblViewWarning.Visible = true;
                lblViewWarning.Text = "You must enter employee ID";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEmpId.Text))
            {
                enableControls();
            }
            else
            {
                lblViewWarning.Visible = true;
                lblViewWarning.Text = "You must enter employee ID";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEmpId.Text))
            {
                String source = @"Data Source=GAMEFREAK;Initial Catalog=Software_ProjectDB;Integrated Security=True";
                SqlConnection conn = new SqlConnection(source);

                conn.Open();
                String queryDisplay = "SELECT * FROM Employee WHERE EmployeeID = " + int.Parse(txtEmpId.Text);
                String queryUpdate = "UPDATE Employee SET phoneNumber='" + this.txtPhone.Text + "', email='" + this.txtEmail.Text + "', address='" + this.txtAdd1.Text + "' WHERE EmployeeID = '" + this.txtEmpId.Text + "'";
                SqlCommand cmd = new SqlCommand(queryUpdate, conn);
                SqlCommand cmd1 = new SqlCommand(queryDisplay, conn);
                SqlDataReader mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    txtFname.Text = mdr["firstName"].ToString();
                    txtLname.Text = mdr["lastName"].ToString();
                    txtPhone.Text = mdr["phoneNumber"].ToString();
                    txtEmail.Text = mdr["email"].ToString();
                    lblSSN.Text = mdr["socialNumber"].ToString();
                    txtAdd1.Text = mdr["address"].ToString();
                }
                conn.Close();

                disableControls();
            }
            else
            {
                lblViewWarning.Visible = true;
                lblViewWarning.Text = "You must enter employee ID";
            }
        }
        void enableControls()
        {
            txtFname.Enabled = true;
            txtLname.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
            txtAdd1.Enabled = true;
        }

        void disableControls()
        {
            txtFname.Enabled = false;
            txtLname.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtAdd1.Enabled = false;
        }
    }
}