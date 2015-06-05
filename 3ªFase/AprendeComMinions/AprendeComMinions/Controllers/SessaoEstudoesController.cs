using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AprendeComMinions.Models;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace AprendeComMinions.Controllers
{
    public class SessaoEstudoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SessaoEstudoes
        public ActionResult Index()
        {
            var email = User.Identity.GetUserName();

            if (email != "")
            {
                Utilizador user = db.Utilizadores.Where(x => x.Username == email).First();
                @ViewBag.username = user.Username;
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Utilizadors");
            }
        }

        // GET: SessaoEstudoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessaoEstudo sessaoEstudo = db.SessoesEstudo.Find(id);
            if (sessaoEstudo == null)
            {
                return HttpNotFound();
            }
            return View(sessaoEstudo);
        }

        // GET: SessaoEstudoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SessaoEstudoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Tema")] SessaoEstudo sessaoEstudo)
        {
            if (ModelState.IsValid)
            {
                string tema = (String)sessaoEstudo.Tema;
                IEnumerable<Aula> aulasSessao = db.Aulas.Where(x => x.Tema == tema).ToList();
                sessaoEstudo.Aulas = new List<Aula>();
                foreach (Aula a in aulasSessao)
                {
                    sessaoEstudo.Aulas.Add(a);
                }


                IEnumerable<Exercicio> exSessao = db.Exercicios.Where(x => x.Tema == tema).ToList();
                sessaoEstudo.Exercicios = new List<Exercicio>();
                foreach (Exercicio e in exSessao)
                {
                    sessaoEstudo.Exercicios.Add(e);
                }

                IEnumerable<Teste> testSessao = db.Testes.Where(x => x.Tema == tema).ToList();
                sessaoEstudo.Testes = new List<Teste>();
                foreach (Teste t in testSessao)
                {
                    sessaoEstudo.Testes.Add(t);
                }


                db.SessoesEstudo.Add(sessaoEstudo);
                db.SaveChanges();
                return RedirectToAction("Index");


            }
            return View(sessaoEstudo);
        }

        // GET: SessaoEstudoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessaoEstudo sessaoEstudo = db.SessoesEstudo.Find(id);
            if (sessaoEstudo == null)
            {
                return HttpNotFound();
            }
            return View(sessaoEstudo);
        }

        // POST: SessaoEstudoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SessaoEstudoID,Data,Tema")] SessaoEstudo sessaoEstudo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sessaoEstudo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sessaoEstudo);
        }

        // GET: SessaoEstudoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessaoEstudo sessaoEstudo = db.SessoesEstudo.Find(id);
            if (sessaoEstudo == null)
            {
                return HttpNotFound();
            }
            return View(sessaoEstudo);
        }

        // POST: SessaoEstudoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SessaoEstudo sessaoEstudo = db.SessoesEstudo.Find(id);
            db.SessoesEstudo.Remove(sessaoEstudo);
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
