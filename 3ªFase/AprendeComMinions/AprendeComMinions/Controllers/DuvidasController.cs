using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AprendeComMinions.Models;

namespace AprendeComMinions.Controllers
{
    public class DuvidasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Duvidas
        public ActionResult Index()
        {
            return View(db.Duvidas.ToList());
        }

        // GET: Duvidas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duvida duvida = db.Duvidas.Find(id);
            if (duvida == null)
            {
                return HttpNotFound();
            }
            return View(duvida);
        }

        // GET: Duvidas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Duvidas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DuvidaID,Descricao")] Duvida duvida)
        {
            if (ModelState.IsValid)
            {
                db.Duvidas.Add(duvida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(duvida);
        }

        // GET: Duvidas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duvida duvida = db.Duvidas.Find(id);
            if (duvida == null)
            {
                return HttpNotFound();
            }
            return View(duvida);
        }

        // POST: Duvidas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DuvidaID,Descricao")] Duvida duvida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(duvida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(duvida);
        }

        // GET: Duvidas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duvida duvida = db.Duvidas.Find(id);
            if (duvida == null)
            {
                return HttpNotFound();
            }
            return View(duvida);
        }

        // POST: Duvidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Duvida duvida = db.Duvidas.Find(id);
            db.Duvidas.Remove(duvida);
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
