using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BloodBanking.Models;
using BloodBanking.Repository;

namespace BloodBanking.Controllers
{
    public class RegionsController : Controller
    {
        private BloodBankingContext db = new BloodBankingContext();

        // GET: Regions
        public ActionResult Index()
        {
            return View(db.Regions.ToList());
        }

        // GET: Regions/Details/5
        public ActionResult Details(long id)
        {
            return View(new RegionRepository().GetOne(id)); 
        }

        // GET: Regions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Regions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Region region)
            {
                var result = new RegionRepository().AddRegion(region);
                return RedirectToAction("Index");
            }


        // GET: Regions/Edit/5
        public ActionResult Edit(long id)
        {
            return View(new RegionRepository().GetOne(id));
        }
        // POST: Regions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Region region)
        {
            if (ModelState.IsValid)
            {
                db.Entry(region).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(region);
        }

        // GET: Regions/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Region region = db.Regions.Find(id);
            if (region == null)
            {
                return HttpNotFound();
            }
            return View(region);
        }

        // POST: Regions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Region region = db.Regions.Find(id);
            db.Regions.Remove(region);
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
