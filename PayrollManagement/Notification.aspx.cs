using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollManagement
{
    public partial class Notification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void confirm_Click(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient();
            MailMessage message = new MailMessage();
            try
            {
                // Prepare receiving email address
                message.To.Add(new MailAddress(
                    toAddressTxtBox.Text, "To You"));
                // Prepare sending email address
                message.From = new MailAddress(
                    "testmail.fuad@gmail.com", "Libra Pay");
                message.Subject = subjectTxtBox.Text;
                message.Body = messageTxtBox.Text +
                    "<br/><br/>------------------------------------<br/>";
                message.IsBodyHtml = true;
                // Set server details
                smtpClient.Host = "smtp.gmail.com";
                // Send the email
                smtpClient.Send(message);
                // Inform the user
                resultLabel.Text = "Email sent.";
            }
            catch
            {
                // Display error message
                resultLabel.Text = "Coudn't send the message!";
            }
        }

        protected void clear_Click(object sender, EventArgs e)
        {

        }
    }
}