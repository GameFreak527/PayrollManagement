using PayrollManagement.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollManagement
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String today = DateTime.Now.ToString();
            Console.WriteLine(today);
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            int employeeId = Database.authenticateUser(int.Parse(employeeIdTxtBox.Text), passwordTxtBox.Text);

            if (employeeId > 0)
            {
                Session["employeeId"] = employeeId;
                Session["loginTime"] = DateTime.Now.ToString("yyyy-M-dd hh:mm:ss tt");
                Response.Redirect("Index.aspx");
            }
            else
            {
                commonLabel.Text = "Please check Employee Id or Password";
            }

            // Store the login and logout time in database

        }
    }
}