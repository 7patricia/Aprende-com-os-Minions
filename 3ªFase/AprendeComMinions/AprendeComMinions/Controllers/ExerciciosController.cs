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
    public class ExerciciosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Exercicios
        public ActionResult Index()
        {
            return View(db.Exercicios.ToList());
        }

        // GET: Exercicios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exercicio exercicio = db.Exercicios.Find(id);
            if (exercicio == null)
            {
                return HttpNotFound();
            }
            return View(exercicio);
        }

        // GET: Exercicios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exercicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExercicioID,GrauDif,Tema")] Exercicio exercicio)
        {
            if (ModelState.IsValid)
            {
                db.Exercicios.Add(exercicio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exercicio);
        }

        // GET: Exercicios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exercicio exercicio = db.Exercicios.Find(id);
            if (exercicio == null)
            {
                return HttpNotFound();
            }
            return View(exercicio);
        }

        // POST: Exercicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExercicioID,GrauDif,Tema")] Exercicio exercicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exercicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exercicio);
        }

        // GET: Exercicios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exercicio exercicio = db.Exercicios.Find(id);
            if (exercicio == null)
            {
                return HttpNotFound();
            }
            return View(exercicio);
        }

        // POST: Exercicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exercicio exercicio = db.Exercicios.Find(id);
            db.Exercicios.Remove(exercicio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //cotacao de cada pergunta=5
        public ActionResult CotacaoExercicio(List<Pergunta> perguntas) {
            int cotacao = 0;
            foreach (Pergunta p in perguntas) { 
                if(p.ValidaResposta())
            }
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
