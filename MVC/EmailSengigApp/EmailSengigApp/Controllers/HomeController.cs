﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace EmailSengigApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
                                                                               
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SendEmail()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SendEmail(string receiver, string subject, string message)
        {
            //try
           // {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("stackOverFlow7085@gmail.com", "StackOverFlow");
                    var receiverEmail = new MailAddress(receiver, "Receiver");
                    var password = "StackOverFlow@7085";
                    var sub = subject;
                    var body = message;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 465,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    return View();
                }
           // }
            //catch (Exception)
            //{
            //    ViewBag.Error = "Some Error";
            //}
            return View();
        }
    }
}