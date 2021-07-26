using Internationalizationdemo.Helpers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Internationalizationdemo.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public ActionResult Index()
        {
            return View();
        }

        protected override void ExecuteCore()
        {
            int Culture = 0;
            if(this.Session == null || this.Session["CurrentCulture"]== null)
            {
                int.TryParse(System.Configuration.ConfigurationManager.AppSettings["Culture"], out Culture);
                this.Session["CurrentCulture"] = "Culture";
            }
            else
            {
                Culture = (int)this.Session["currentCulture"];
            }
            CultureHelper.CurrentCulture = Culture;
            base.ExecuteCore();
        }
        protected override bool DisableAsyncSupport
        {
            get
            {
                return true;
            }
        }
    }
}