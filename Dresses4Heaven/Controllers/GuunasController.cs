using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dresses4Heaven.DAL;
using Dresses4Heaven.Models;

namespace Dresses4Heaven.Controllers
{
    public class GuunasController : Controller
    {
        private DressesContext db = new DressesContext();

        // GET: Guunas
        public ActionResult Index()
        {
            return View(db.Guunas.ToList());
        }

        // GET: Guunas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guuna guuna = db.Guunas.Find(id);
            if (guuna == null)
            {
                return HttpNotFound();
            }
            return View(guuna);
        }

        // GET: Guunas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Guunas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GuunaID,dressDesc,DressNotes,UnitPrice,UKSize,Shoulders,Bust,Waist,Hips,HollowToHem,Sleeve,Trail,FittingDate")] Guuna guuna)
        {
            if (ModelState.IsValid)
            {
                db.Guunas.Add(guuna);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(guuna);
        }

        // GET: Guunas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guuna guuna = db.Guunas.Find(id);
            if (guuna == null)
            {
                return HttpNotFound();
            }
            return View(guuna);
        }

        // POST: Guunas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GuunaID,dressDesc,DressNotes,UnitPrice,UKSize,Shoulders,Bust,Waist,Hips,HollowToHem,Sleeve,Trail,FittingDate")] Guuna guuna)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guuna).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guuna);
        }

        // GET: Guunas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guuna guuna = db.Guunas.Find(id);
            if (guuna == null)
            {
                return HttpNotFound();
            }
            return View(guuna);
        }

        // POST: Guunas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Guuna guuna = db.Guunas.Find(id);
            db.Guunas.Remove(guuna);
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
