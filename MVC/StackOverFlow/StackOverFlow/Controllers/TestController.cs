using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StackOverFlow.Controllers
{
    [Authorize]
    public class TestController : Controller
    {
        // GET: Test
        
        public ActionResult Identity()
        {
            return Content("We are using Identity");
        }
        public ActionResult NonIdentity()
        {
            return Content("We are not using Identity");
        }
    }
}