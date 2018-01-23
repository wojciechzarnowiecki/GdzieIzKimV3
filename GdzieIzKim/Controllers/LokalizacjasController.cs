using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GdzieIzKim.DAL;
using GdzieIzKim.Models;

namespace GdzieIzKim.Controllers
{
    public class LokalizacjasController : Controller
    {
        private contextDB db = new contextDB();

        // GET: Lokalizacjas
        public ActionResult Index()
        {
            return View(db.Lokalizacje.ToList());
        }

        // GET: Lokalizacjas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lokalizacja lokalizacja = db.Lokalizacje.Find(id);
            if (lokalizacja == null)
            {
                return HttpNotFound();
            }
            return View(lokalizacja);
        }

        // GET: Lokalizacjas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lokalizacjas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LokalizacjaId,nazwa,adres")] Lokalizacja lokalizacja)
        {
            if (ModelState.IsValid)
            {
                db.Lokalizacje.Add(lokalizacja);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lokalizacja);
        }

        // GET: Lokalizacjas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lokalizacja lokalizacja = db.Lokalizacje.Find(id);
            if (lokalizacja == null)
            {
                return HttpNotFound();
            }
            return View(lokalizacja);
        }

        // POST: Lokalizacjas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LokalizacjaId,nazwa,adres")] Lokalizacja lokalizacja)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lokalizacja).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lokalizacja);
        }

        // GET: Lokalizacjas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lokalizacja lokalizacja = db.Lokalizacje.Find(id);
            if (lokalizacja == null)
            {
                return HttpNotFound();
            }
            return View(lokalizacja);
        }

        // POST: Lokalizacjas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lokalizacja lokalizacja = db.Lokalizacje.Find(id);
            db.Lokalizacje.Remove(lokalizacja);
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
