using MVCStackOverFlow.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStackOverFlow.Code
{
    public class CustomAuthorizationAttribute : AuthorizeAttribute
    {
        private readonly string[] allowedroles;
        public CustomAuthorizationAttribute(params string[] roles)
        {
            this.allowedroles = roles;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = false;
            var userId = Convert.ToInt32(httpContext.Session["UserId"]);
            if (!string.IsNullOrEmpty(userId.ToString()))
            {
                using(var context = new StackOverFlowContext())
                {
                    var userRole = (from u in context.Users
                                    join r in context.UserRoles
                                    on u.UserRoleId equals r.Id
                                    where u.UserID == userId
                                    select new
                                    {
                                        r.Name
                                    }).FirstOrDefault();
                    foreach(var role in allowedroles)
                    {
                        if (role == userRole.Name) return true;
                    }
                }
                
            }
            return authorize;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                new System.Web.Routing.RouteValueDictionary
                {
                    {"controller","Authentication" },
                    {"action","UnAuthorized" }
                });
        }
    }
}