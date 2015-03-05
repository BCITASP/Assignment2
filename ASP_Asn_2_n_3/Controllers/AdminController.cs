using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using ASP_Asn_2_n_3.Models;

namespace ASP_Asn_2_n_3.Controllers
{
    //[Authorize(Roles="Administrator")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Roles()
        {
            var context = new ApplicationDbContext();
            List<String> usernames = (from c in context.Users
                            select new { c.Email }).Select(m => m.Email).ToList();
            List<String> roles = (from c in context.Roles
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
            string username = Request.Form["Users"];
            string role = Request.Form["Roles"];
            return View("index");
        }



        public ActionResult Suspend()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Suspend()
        {
            return View();
        }

        public ActionResult Unsuspend()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Unsuspend()
        {
            return View();
        }
    }


}