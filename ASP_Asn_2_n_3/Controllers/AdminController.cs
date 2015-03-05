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
            if(TempData.ContainsKey("Message"))
            {
                ViewBag.Message = TempData["Message"];
            }
            
            var context = new ApplicationDbContext();

            // Get users who have lockout enabled and are not currently suspended
            List<string> usernames = (
                from c in context.Users
                where c.LockoutEnabled == true
                where ((c.LockoutEndDateUtc <= DateTime.Now) || (c.LockoutEndDateUtc == null))
                select new { c.Email, c.Id }).Select(m => m.Email).ToList();

            // create list of all users to be used in SelectList
            List<SelectListItem> usersSL = new List<SelectListItem>();
            foreach (string user in usernames)
            {
                usersSL.Add(new SelectListItem { Text = user, Value = user });
            }

            ViewBag.Users = usersSL;

            return View();
        }

        [HttpPost]
        public ActionResult SuspendUser()
        {
            // get username from post and create UserManager
            string username = Request.Form["Users"];

            if(username == null)
            {
                return RedirectToAction("Suspend");
            }

            var context = new ApplicationDbContext();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            // Set LockoutEndDate to an ureasonable date in the future
            // to suspend the selected user indefinitely
            DateTime dt = new DateTime(4999, 01, 01, 00, 00, 00);
            DateTimeOffset dto = new DateTimeOffset(dt);
            UserManager.SetLockoutEndDateAsync(username, dto);

            TempData["Message"] = String.Format("User {0} has been suspended", username);
            
            return RedirectToAction("Suspend");
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