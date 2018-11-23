using PayrollManagement.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollManagement
{
    public partial class PasswordChange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            employeeId.Text = ((int)HttpContext.Current.Session["EmployeeId"]).ToString();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            int empId = int.Parse(employeeId.Text);
            String pass = confirmPasswordTxtBox.Text;
            int flag = Database.updateTable(empId, pass);
            if (flag > 0)
            {
                statusLabel.Text = "Password Updated";
                confirmPasswordTxtBox.Text = "";
                passwordTxtBox.Text = "";
            }
            else
            {
                statusLabel.Text = "Password Update Failed";
            }
        }
    }
}