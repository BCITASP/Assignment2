using ASP_Asn_2_n_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_Asn_2_n_3.Controllers
{
    public class MVCReportController : Controller
    {
        // GET: MVCReport
        public ActionResult Index()
        {
            GoodSamaritanContext ctx = new GoodSamaritanContext();

            IEnumerable<SelectListItem> siYears = (from c in ctx.FiscalYears
                                                   select new { c.FiscalYearId, c.Years }).AsEnumerable()
                                                   .Select(m => new SelectListItem()
                                                   {
                                                       Value = m.FiscalYearId.ToString(),
                                                       Text = m.Years
                                                   });
            ViewBag.yearsSelect = new SelectList(siYears, "Value", "Text");
            return View();
        }

        // POST: MVCReport/DisplayReport
        [HttpPost]
        public ActionResult Report()
        {

            return View();
        }
    }
}