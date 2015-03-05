﻿using System;
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
        // Redirect default to Roles
        public ActionResult Index()
        {
            return RedirectToAction("Roles");
        }

        // GET: Admin
        public ActionResult Roles()
        {
            if (TempData.ContainsKey("Message"))
            {
                ViewBag.Message = TempData["Message"];
            }
            ViewBag.Users = GetUsersList();
            ViewBag.Roles = GetRolesList();
            return View();
        }

        [HttpPost]
        public ActionResult AddRole()
        {
            string userid = Request.Form["Users"];
            string role = Request.Form["Roles"];
            // If either is null, function was accessed directly
            if (userid == null || role == null)
            { return RedirectToAction("Roles"); }

            var context = new ApplicationDbContext();
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            string username = UserManager.FindById(userid).Email;
            IList<string> roles = UserManager.GetRoles(userid);
            if (!roles.Contains(role)) // User is not already in the role being assigned
            {
                UserManager.AddToRole(userid, role);
                TempData["Message"] = String.Format("User {0} has been added to role {1}", username, role);
            }
            else
            {
                TempData["Message"] = String.Format("User {0} already exists in role {1}", username, role);
            }
            return RedirectToAction("Roles");
        }

        public ActionResult Remove()
        {
            if (TempData.ContainsKey("Message"))
            {
                ViewBag.Message = TempData["Message"];
            }
            ViewBag.Users = GetUsersList();
            return View("RemoveRole1");
        }

        public ActionResult RemoveChooseRole()
        {
            if (Request.Form["Users"] == null)
            {
                return RedirectToAction("Remove");
            }
            string userid = Request.Form["Users"];
            ViewBag.UserId = userid;
            ViewBag.Roles = GetRolesById(userid);
            return View("RemoveRole2");
        }

        [HttpPost]
        public ActionResult RemoveRole()
        {
            string userid = Request.Form["userid"];
            string role = Request.Form["Roles"];
            
            // If either is null, this function was accessed directly
            if (userid == null || role == null)
            {
                return RedirectToAction("Remove");
            }

            string username = GetUsernameById(userid);
            // Check if it is attempting to remove last Administrator
            if (role == "Administrator")
            {
                if (isLastAdmin())
                {
                    TempData["Message"] = String.Format("Cannot remove user {0} from role {1} because " +
                                            "he or she is the last Administrator", username, role);
                    return RedirectToAction("Remove");
                }
            }
            
            // Begin remove user from role
            var context = new ApplicationDbContext();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            UserManager.RemoveFromRole(userid, role);
            TempData["Message"] = String.Format("User {0} has been removed from role {1}", username, role);

            return RedirectToAction("Remove");
        }

        private List<SelectListItem> GetUsersList()
        {
            var context = new ApplicationDbContext();
            var users = from c in context.Users
                        select c;
            List<SelectListItem> usersSL = new List<SelectListItem>();
            foreach (var user in users)
            {
                usersSL.Add(new SelectListItem { Text = user.Email, Value = user.Id });
            }
            return usersSL;
        }

        private List<SelectListItem> GetRolesList()
        {
            var context = new ApplicationDbContext();

            var roles = (from c in context.Roles
                         select new { c.Name }).Select(m => m.Name).ToList();



            List<SelectListItem> rolesSL = new List<SelectListItem>();
            foreach (string role in roles)
            {
                rolesSL.Add(new SelectListItem { Text = role, Value = role });
            }
            return rolesSL;
        }

        private List<SelectListItem> GetRolesById(string userid)
        {
            var context = new ApplicationDbContext();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            
            IList<string> roles = UserManager.GetRoles(userid);
            List<SelectListItem> rolesSL = new List<SelectListItem>();
            foreach(var role in roles)
            {
                rolesSL.Add(new SelectListItem { Text = role });
            }
            return rolesSL;
        }

        private string GetUsernameById(string userId)
        {
            var context = new ApplicationDbContext();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            return UserManager.FindById(userId).Email;
        }

        private bool isLastAdmin()
        {
            var context = new ApplicationDbContext();
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            int num = RoleManager.FindByName("Administrator").Users.Count();
            if(num == 1)
            {
                return true;
            }
            return false;
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