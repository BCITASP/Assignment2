using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASP_Asn_2_n_3.Models;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace ASP_Asn_2_n_3.Controllers
{
    public class ReportController : ApiController
    {
        public class YearObj
        {
            public int id;
            public string year;
        }


        // GET api/report/getyear
        public IEnumerable<YearObj> GetYear()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            GoodSamaritanContext ctx = new GoodSamaritanContext();
            List<YearObj> yearList = new List<YearObj>();
            var qry = (from c in ctx.FiscalYears
                      select new { c.FiscalYearId, c.Years });
            foreach (var item in qry)
            {
                yearList.Add(new YearObj { id = item.FiscalYearId, year = item.Years });
            }
            return yearList;
        }

        [HttpGet]
        public string getReport(int monthnum, int yearid)
        {
            return monthnum + " : " + yearid;
        }
    }
}
