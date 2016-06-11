using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project.Data;
using Project.Models;

namespace Project.Web.Controllers
{
    public class LightScaffoldFormsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: LightScaffoldForms
        public ActionResult Index()
        {
            var lightScaffoldForms = db.LightScaffoldForm.Include(l => l.BusinessPartner);
            return View(lightScaffoldForms.ToList());
        }

        // GET: LightScaffoldForms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LightScaffoldForm lightScaffoldForm = db.LightScaffoldForm.Find(id);
            if (lightScaffoldForm == null)
            {
                return HttpNotFound();
            }
            return View(lightScaffoldForm);
        }

        // GET: LightScaffoldForms/Create
        public ActionResult Create()
        {
            ViewBag.BusinessPartnerID = new SelectList(db.BusinessPartners, "ID", "Name");
            return View();
        }

        // POST: LightScaffoldForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LoadLength,LoadWidth,LoadHeight,ShelfLength,ShelfDepth,ShelfHeight,ShelfNumber,ShelfWeightCapacity,IsDimensionsKnown,BusinessPartnerID")] LightScaffoldForm lightScaffoldForm)
        {
            if (ModelState.IsValid)
            {
                db.LightScaffoldForm.Add(lightScaffoldForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BusinessPartnerID = new SelectList(db.BusinessPartners, "ID", "Name", lightScaffoldForm.BusinessPartnerID);
            return View(lightScaffoldForm);
        }

        // GET: LightScaffoldForms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LightScaffoldForm lightScaffoldForm = db.LightScaffoldForm.Find(id);
            if (lightScaffoldForm == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusinessPartnerID = new SelectList(db.BusinessPartners, "ID", "Name", lightScaffoldForm.BusinessPartnerID);
            return View(lightScaffoldForm);
        }

        // POST: LightScaffoldForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LoadLength,LoadWidth,LoadHeight,ShelfLength,ShelfDepth,ShelfHeight,ShelfNumber,ShelfWeightCapacity,IsDimensionsKnown,BusinessPartnerID")] LightScaffoldForm lightScaffoldForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lightScaffoldForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BusinessPartnerID = new SelectList(db.BusinessPartners, "ID", "Name", lightScaffoldForm.BusinessPartnerID);
            return View(lightScaffoldForm);
        }

        // GET: LightScaffoldForms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LightScaffoldForm lightScaffoldForm = db.LightScaffoldForm.Find(id);
            if (lightScaffoldForm == null)
            {
                return HttpNotFound();
            }
            return View(lightScaffoldForm);
        }

        // POST: LightScaffoldForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LightScaffoldForm lightScaffoldForm = db.LightScaffoldForm.Find(id);

            db.LightScaffoldForm.Remove(lightScaffoldForm);
            db.SaveChanges();
            db.Dispose();
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
