using MVCStackOverFlow.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStackOverFlow.Controllers
{
    public class HomeController : Controller
    {
        private StackOverFlowContext context = new StackOverFlowContext();
        public ActionResult Index()
        {
            var Questions = context.Questions.ToList();
            return View(Questions);
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
    }
}