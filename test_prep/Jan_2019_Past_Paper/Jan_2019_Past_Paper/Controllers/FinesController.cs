using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Jan_2019_Past_Paper.DAL;
using Jan_2019_Past_Paper.Models;

namespace Jan_2019_Past_Paper.Controllers
{
    public class FinesController : Controller
    {
        private TrafficContext db = new TrafficContext();

        // GET: Fines
        public ActionResult Index(string sortOrder)
        {

            ViewBag.LicenseSortParm = String.IsNullOrEmpty(sortOrder) ? "license_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            var threeYearsAgo = DateTime.Now.AddYears(-3);

            var fines = from f in db.Fine
                        where f.OffenseDate > threeYearsAgo
                        select f;

            switch (sortOrder)
            {
                case "license_desc":
                    fines = fines.OrderByDescending(f => f.LicensePlate);
                    break;
                case "Date":
                    fines = fines.OrderBy(f => f.OffenseDate);
                    break;
                case "date_desc":
                    fines = fines.OrderByDescending(f => f.OffenseDate);
                    break;
                default:
                    fines = fines.OrderBy(f => f.LicensePlate);
                    break;
            }

            return View(fines.ToList());
        }

        // GET: Fines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fine fine = db.Fine.Find(id);
            if (fine == null)
            {
                return HttpNotFound();
            }
            return View(fine);
        }

        // GET: Fines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,LicensePlate,VehicleType,Offense,OffenseDetail,OffenseDate,OffenseTime,Amount,Outstanding")] Fine fine)
        {
            if (ModelState.IsValid)
            {
                db.Fine.Add(fine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fine);
        }

        // GET: Fines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fine fine = db.Fine.Find(id);
            if (fine == null)
            {
                return HttpNotFound();
            }
            return View(fine);
        }

        // POST: Fines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,LicensePlate,VehicleType,Offense,OffenseDetail,OffenseDate,OffenseTime,Amount,Outstanding")] Fine fine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fine);
        }

        // GET: Fines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fine fine = db.Fine.Find(id);
            if (fine == null)
            {
                return HttpNotFound();
            }
            return View(fine);
        }

        // POST: Fines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fine fine = db.Fine.Find(id);
            db.Fine.Remove(fine);
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
