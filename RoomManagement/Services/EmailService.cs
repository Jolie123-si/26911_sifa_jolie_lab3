using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace RoomManagement.Services
{
    // Sends emails (used by "Forgot password?") (Gmail SMTP).
    // The settings are in App.config: EmailEnabled, SmtpHost, SmtpPort, SmtpUser, SmtpPassword.
    public class EmailService
    {
        // True when App.config says EmailEnabled = true
        public static bool IsEnabled()
        {
            return ConfigurationManager.AppSettings["EmailEnabled"] == "true";
        }

        public static void SendEmail(string to, string subject, string body)
        {
            string host = ConfigurationManager.AppSettings["SmtpHost"];
            int port = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
            string user = ConfigurationManager.AppSettings["SmtpUser"];
            string password = ConfigurationManager.AppSettings["SmtpPassword"];

            if (user == "" || password == "")
            {
                throw new Exception("Email is not set up. Fill in SmtpUser and SmtpPassword in App.config.");
            }

            MailMessage message = new MailMessage(user, to, subject, body);

            SmtpClient client = new SmtpClient(host, port);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(user, password);

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                throw new Exception("The email could not be sent: " + ex.Message);
            }
            finally
            {
                message.Dispose();
                client.Dispose();
            }
        }
    }
}
