using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using JovenesA.Services;

namespace JovenesA.App_Start
{
  public class MyEmailService : IDisposable
  {
    public async Task SendAsync(IdentityMessage message)
    {
      // convert IdentityMessage to a MailMessage
      var msg =
         new MailMessage(new MailAddress("noreply@kapilla.net", "(do not reply)"),
         new MailAddress(message.Destination))
         {
           Subject = message.Subject,
           Body = message.Body,
           IsBodyHtml = true
         };

        using (var client = new SmtpClient()) // SmtpClient configuration comes from config file
        {
          try
          {
            await client.SendMailAsync(msg);
          }
          catch(Exception ex)
          {
                    Log4.Trace("Exception in SendMailAsync: " + ex.Message);
          }
        }
    }

    public void Dispose() { }
  }
}