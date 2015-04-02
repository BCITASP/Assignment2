﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASP_Asn_2_n_3.Models;
using Newtonsoft.Json;

namespace ASP_Asn_2_n_3.Controllers
{
    public class ReportController : ApiController
    {
        public class YearObj
        {
            public int id;
            public string year;
        }

        public class ReportObj
        {
            public int statusOpen;
            public int statusClosed;
            public int statusReopened;

            public int programCrisis;
            public int programCourt;
            public int programSMART;
            public int programDVU;
            public int programMCFD;

            public int genderFemale;
            public int genderMale;
            public int genderTrans;

            public int age24_65;
            public int age18_25;
            public int age12_19;
            public int age13;
            public int age64;
        }


        // GET api/report/getyear
        public IEnumerable<YearObj> GetYear()
        {
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
        public ReportObj GetReport(int monthnum, int yearid)
        {
            GoodSamaritanContext ctx = new GoodSamaritanContext();
            ReportObj reportData = new ReportObj();

            // Status
            reportData.statusOpen = (from c in ctx.Clients
                                    where c.Month == monthnum
                                    where c.FiscalYearId == yearid
                                    select c.StatusOfFile.Status == "Open").Count();
            reportData.statusClosed = (from c in ctx.Clients
                                     where c.Month == monthnum
                                     where c.FiscalYearId == yearid
                                     select c.StatusOfFile.Status == "Closed").Count();
            reportData.statusReopened = (from c in ctx.Clients
                                     where c.Month == monthnum
                                     where c.FiscalYearId == yearid
                                     select c.StatusOfFile.Status == "Reopened").Count();

            // Program
            reportData.programCrisis = (from c in ctx.Clients
                                         where c.Month == monthnum
                                         where c.FiscalYearId == yearid
                                         select c.Program.Type == "Crisis").Count();
            reportData.programCourt = (from c in ctx.Clients
                                        where c.Month == monthnum
                                        where c.FiscalYearId == yearid
                                        select c.Program.Type == "Court").Count();
            reportData.programSMART = (from c in ctx.Clients
                                        where c.Month == monthnum
                                        where c.FiscalYearId == yearid
                                        select c.Program.Type == "SMART").Count();
            reportData.programDVU = (from c in ctx.Clients
                                        where c.Month == monthnum
                                        where c.FiscalYearId == yearid
                                        select c.Program.Type == "DVU").Count();
            reportData.programMCFD = (from c in ctx.Clients
                                        where c.Month == monthnum
                                        where c.FiscalYearId == yearid
                                        select c.Program.Type == "MCFD").Count();

            // Gender
            reportData.genderMale = (from c in ctx.Clients
                                     where c.Month == monthnum
                                     where c.FiscalYearId == yearid
                                     select c.Gender == "Male").Count();
            reportData.genderFemale = (from c in ctx.Clients
                                     where c.Month == monthnum
                                     where c.FiscalYearId == yearid
                                     select c.Gender == "Female").Count();
            reportData.genderTrans = (from c in ctx.Clients
                                     where c.Month == monthnum
                                     where c.FiscalYearId == yearid
                                     select c.Gender == "Trans").Count();

            // Age
            reportData.age24_65 = (from c in ctx.Clients
                                   where c.Month == monthnum
                                   where c.FiscalYearId == yearid
                                   select c.Age.Range == "Adult >24<65").Count();
            reportData.age18_25 = (from c in ctx.Clients
                                   where c.Month == monthnum
                                   where c.FiscalYearId == yearid
                                   select c.Age.Range == "Youth >18<25").Count();
            reportData.age12_19 = (from c in ctx.Clients
                                   where c.Month == monthnum
                                   where c.FiscalYearId == yearid
                                   select c.Age.Range == "Youth >12<19").Count();
            reportData.age13 = (from c in ctx.Clients
                                where c.Month == monthnum
                                where c.FiscalYearId == yearid
                                select c.Age.Range == "Child <13").Count();
            reportData.age64 = (from c in ctx.Clients
                                where c.Month == monthnum
                                where c.FiscalYearId == yearid
                                select c.Age.Range == "Senior >64").Count();
            return reportData;
        }
    }
}
