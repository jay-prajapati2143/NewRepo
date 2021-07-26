

using Microsoft.IdentityModel.Tokens;

using MVCStackOverFlow.Models;
using MVCStackOverFlow.Models.Authenticaion;

using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCStackOverFlow.Controllers
{
    public class AuthenticationController : Controller
    {
        private StackOverFlowContext context = new StackOverFlowContext();
        
        // GET: Authentication

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult  Login(LoginModel Model)
        {
            var user = context.Users.Where(u => u.UserName == Model.UserName).FirstOrDefault();
            if (user!=null){
                if(Model.UserName == user.UserName && Model.Password == user.HashPassword)
                {
                    Session["UserName"] = user.UserName;
                    Session["UserId"] = user.UserID;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid User Name of Password");
                    return View(Model);
                }
            }
            else{
                ModelState.AddModelError("", "Invalid User Name or Password");
                return View(Model);
            }
            
        }

        [HttpGet]
        public ActionResult Register()
        {
            
            return View();
        }


        [HttpPost]
        public ActionResult Register(RegisterModel Model)
        {
            var IsExist = context.Users.Any(u => u.UserName == Model.UserName);
            if (!IsExist)
            {
                var user = new User();
                user.UserName = Model.UserName;
                user.EmailID = Model.Email;
                user.FullName = Model.FullName;
                user.HashPassword = Model.Password;
                user.Reputaion = 0;
                user.ProfileViews = 0;
                user.IsEmailConfirmed = false;
                user.UserRoleId = context.UserRoles.Where(u=>u.Name == "User").FirstOrDefault().Id;
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "UserName is Already Exist");
                return View(Model);
            }

                
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            Session["UserName"] = string.Empty;
            Session["UserId"] = string.Empty;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult UnAuthorized()
        {
            ViewBag.Message = "Unauthorized Page!";

            return View();
        }
    }
}