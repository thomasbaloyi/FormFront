using FormFront.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FormFront.Controllers
{
    public class EmailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Index(Mail email)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(email.To);
                mail.From = new MailAddress(email.From);
                mail.Subject = email.Subject;
                string Body = email.Body;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("username", "password"); // Enter seders User name and password  
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return View("Index", email);
            }
            else
            {
                return View();
            }
        }
    }
}
