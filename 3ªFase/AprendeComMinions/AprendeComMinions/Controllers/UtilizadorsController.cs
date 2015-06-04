using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AprendeComMinions.Models;
using System.Web.Security;

namespace AprendeComMinions.Controllers
{
    public class UtilizadorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Utilizadors
        public ActionResult Index()
        {
            int id = Convert.ToInt32(Membership.GetUser().ProviderUserKey.ToString());
            Utilizador u = db.Utilizadores.Find(id);
            Session["User"] = u;
            ViewBag.UtilizadorID = u.UtilizadorID;
            ViewBag.Administrador = u.Administrador;
            ViewBag.GrauDif = u.GrauDif;
            return View(u);
        }

        // GET: Utilizadors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilizador utilizador = db.Utilizadores.Find(id);
            if (utilizador == null)
            {
                return HttpNotFound();
            }
            return View(utilizador);
        }

        // GET: Utilizadors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Utilizadors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UtilizadorID,Username,Password,Administrador,NrRespostasCertas,NrRespostasErradas,NrTestesRealizados,NrSessoesEstudo,GrauDif")] Utilizador utilizador)
        {
            if (ModelState.IsValid)
            {
                db.Utilizadores.Add(utilizador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(utilizador);
        }

        // GET: Utilizadors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilizador utilizador = db.Utilizadores.Find(id);
            if (utilizador == null)
            {
                return HttpNotFound();
            }
            return View(utilizador);
        }

        // POST: Utilizadors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UtilizadorID,Username,Password,Administrador,NrRespostasCertas,NrRespostasErradas,NrTestesRealizados,NrSessoesEstudo,GrauDif")] Utilizador utilizador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(utilizador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(utilizador);
        }

        // GET: Utilizadors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilizador utilizador = db.Utilizadores.Find(id);
            if (utilizador == null)
            {
                return HttpNotFound();
            }
            return View(utilizador);
        }

        // POST: Utilizadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Utilizador utilizador = db.Utilizadores.Find(id);
            db.Utilizadores.Remove(utilizador);
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
