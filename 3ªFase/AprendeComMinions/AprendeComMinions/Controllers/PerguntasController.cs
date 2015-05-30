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
    public class PerguntasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Perguntas
        public ActionResult Index()
        {
            return View(db.Perguntas.ToList());
        }

        // GET: Perguntas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pergunta pergunta = db.Perguntas.Find(id);
            if (pergunta == null)
            {
                return HttpNotFound();
            }
            return View(pergunta);
        }

        // GET: Perguntas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Perguntas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PerguntaID,Descricao")] Pergunta pergunta)
        {
            if (ModelState.IsValid)
            {
                db.Perguntas.Add(pergunta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pergunta);
        }

        // GET: Perguntas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pergunta pergunta = db.Perguntas.Find(id);
            if (pergunta == null)
            {
                return HttpNotFound();
            }
            return View(pergunta);
        }

        // POST: Perguntas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PerguntaID,Descricao")] Pergunta pergunta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pergunta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pergunta);
        }

        // GET: Perguntas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pergunta pergunta = db.Perguntas.Find(id);
            if (pergunta == null)
            {
                return HttpNotFound();
            }
            return View(pergunta);
        }

        // POST: Perguntas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pergunta pergunta = db.Perguntas.Find(id);
            db.Perguntas.Remove(pergunta);
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
