﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using iftekhar_0400034815.Models;

namespace iftekhar_0400034815.Controllers
{
    [Authorize(Roles = "Admin")]

    public class BloodGroupsController : Controller
    {
        private iftekhar_0400034815Entities db = new iftekhar_0400034815Entities();

        // GET: BloodGroups
        public ActionResult Index()
        {
            return View(db.BloodGroups.ToList());
        }

        // GET: BloodGroups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodGroup bloodGroup = db.BloodGroups.Find(id);
            if (bloodGroup == null)
            {
                return HttpNotFound();
            }
            return View(bloodGroup);
        }

        // GET: BloodGroups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BloodGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GroupID,GroupName,Status")] BloodGroup bloodGroup)
        {
            if (ModelState.IsValid)
            {
                db.BloodGroups.Add(bloodGroup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bloodGroup);
        }

        // GET: BloodGroups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodGroup bloodGroup = db.BloodGroups.Find(id);
            if (bloodGroup == null)
            {
                return HttpNotFound();
            }
            return View(bloodGroup);
        }

        // POST: BloodGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GroupID,GroupName,Status")] BloodGroup bloodGroup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bloodGroup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bloodGroup);
        }

        // GET: BloodGroups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodGroup bloodGroup = db.BloodGroups.Find(id);
            if (bloodGroup == null)
            {
                return HttpNotFound();
            }
            return View(bloodGroup);
        }

        // POST: BloodGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BloodGroup bloodGroup = db.BloodGroups.Find(id);
            db.BloodGroups.Remove(bloodGroup);
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
