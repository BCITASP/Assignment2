using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using ASP_Asn_2_n_3.Models;
using System.Web.Security;
using Microsoft.AspNet.Identity;

namespace ASP_Asn_2_n_3.Controllers
{
    //[Authorize(Roles="Administrator")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Roles()
        {
            var context = new ApplicationDbContext();
            List<string> usernames = (from c in context.Users
                            select new { c.Email, c.Id }).Select(m => m.Email).ToList();
;
            var roles = (from c in context.Roles
                        select new { c.Name }).Select(m => m.Name).ToList();

            List<SelectListItem> usersSL = new List<SelectListItem>();
            foreach(string user in usernames)
            {
                usersSL.Add(new SelectListItem { Text = user, Value = user });
            }
            List<SelectListItem> rolesSL = new List<SelectListItem>();
            foreach (string role in roles)
            {
                rolesSL.Add(new SelectListItem { Text = role, Value = role });
            }
            ViewBag.Users = usersSL;
            ViewBag.Roles = rolesSL;
            return View();
        }

        [HttpPost]
        public ActionResult AddRole()
        {
            //string username = Request.Form["Users"];
            //string role = Request.Form["Roles"];
            //var context = new ApplicationDbContext();
            //var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            //var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //IList<string> roles = UserManager.GetRoles
            //if (!roles.Contains(role)) // User is not already in the role being assigned
            //{
            //    System.Web.Security.Roles.AddUserToRole(username, role);
            //    ViewBag.Message = String.Format("User {0} has been added to role {1}", username, role);
            //}
            //else
            //{
            //    ViewBag.Message = String.Format("User {0} already exists in role {1}", username, role);
            //}
            return View("index");
        }

        public ActionResult Suspend()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SuspendUser()
        {
            return View();
        }

        public ActionResult Unsuspend()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UnsuspendUser()
        {
            return View();
        }
    }


}