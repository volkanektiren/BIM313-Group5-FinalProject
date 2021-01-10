using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace BIM313_Group5_FinalProject.Util
{
    class MailSender
    {
        public MailSender(string bookTitle, string to)
        {
            this.bookTitle = bookTitle;
            this.to = to;
            Send();
        }
        public string bookTitle { get; set; }
        public string to { get; set; }
        public void Send()
        { 
            MailMessage message = new MailMessage();
            message.From = new MailAddress("lmsnotificationsystem1@gmail.com");
            message.To.Add(to);
            message.Subject = "LMS - Book Return - " + bookTitle;
            message.Body = "Hello,\n\n" +
                "Please return back " + bookTitle + " within 3 days...\n\n" +
                "LMS Notification System";

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("lmsnotificationsystem1@gmail.com", "lms12345");
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(message);
        }
    }
}
