using StackOverFlow.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StackOverFlow.Controllers
{
    public class HomeController : Controller
    {
        private TempStackOverFlowEntities db = new TempStackOverFlowEntities();
        public ActionResult TopQuestion()
        {
            var quesions = db.Questions.ToList();
            return View(quesions);
        }

        public ActionResult AllQuestoins()
        {
            var quesions = db.Questions.ToList();
            return View(quesions);
        }

        public ActionResult AllUsers()
        {
            var users = db.Users.ToList();
            return View(users);
        }
    }
}