﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP_Asn_2_n_3.Models;

namespace ASP_Asn_2_n_3.Controllers.LookupTableControllers
{
    public class AbuserRelationshipsController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: AbuserRelationships
        public ActionResult Index()
        {
            return View(db.AbuserRelationships.ToList());
        }

        // GET: AbuserRelationships/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbuserRelationship abuserRelationship = db.AbuserRelationships.Find(id);
            if (abuserRelationship == null)
            {
                return HttpNotFound();
            }
            return View(abuserRelationship);
        }

        // GET: AbuserRelationships/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AbuserRelationships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AbuserRelationshipId,Relationship")] AbuserRelationship abuserRelationship)
        {
            if (ModelState.IsValid)
            {
                db.AbuserRelationships.Add(abuserRelationship);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(abuserRelationship);
        }

        // GET: AbuserRelationships/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbuserRelationship abuserRelationship = db.AbuserRelationships.Find(id);
            if (abuserRelationship == null)
            {
                return HttpNotFound();
            }
            return View(abuserRelationship);
        }

        // POST: AbuserRelationships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AbuserRelationshipId,Relationship")] AbuserRelationship abuserRelationship)
        {
            if (ModelState.IsValid)
            {
                db.Entry(abuserRelationship).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(abuserRelationship);
        }

        // GET: AbuserRelationships/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbuserRelationship abuserRelationship = db.AbuserRelationships.Find(id);
            if (abuserRelationship == null)
            {
                return HttpNotFound();
            }
            return View(abuserRelationship);
        }

        // POST: AbuserRelationships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AbuserRelationship abuserRelationship = db.AbuserRelationships.Find(id);
            db.AbuserRelationships.Remove(abuserRelationship);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
