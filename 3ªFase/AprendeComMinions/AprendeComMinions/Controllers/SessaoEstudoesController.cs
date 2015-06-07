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

        public List<DateTime> DatasSessoes(Utilizador u) { 
            List<DateTime> datas= new List<DateTime> ();
           // List<SessaoEstudo> sessoes1 = u.SessaoEstudo.ToList();
            List<SessaoEstudo> sessoes = db.SessoesEstudo.Where(x => x.Utilizador.Username.Equals(u.Username)).ToList();
            foreach (SessaoEstudo s in sessoes) {
                datas.Add(s.Data);
            }
            return datas;
        }

        public void CriaSessao(Utilizador u, string tem) {
            SessaoEstudo sessao = new SessaoEstudo();
            //aulas por por tema e grau
            List<Aula> aulasTema = db.Aulas.Where(x => x.Tema == tem).ToList();
            List<Aula> aulasGrau = new List<Aula>();
            foreach (Aula a in aulasTema) {
                if (a.GrauDif == u.GrauDif)  aulasGrau.Add(a);
                }
            sessao.Aulas = aulasGrau;

            //exercicios por tema e grau
            List<Exercicio> exTema = db.Exercicios.Where(x => x.Tema == tem).ToList();
            List<Exercicio> exGrau = new List<Exercicio>();
            foreach (Exercicio e in exTema)
            {
                if (e.GrauDif == u.GrauDif) exGrau.Add(e);
            }
            sessao.Exercicios = exGrau;

            List<Teste> testeTema = db.Testes.Where(x => x.Tema == tem).ToList();
            List<Teste> testeGrau = new List<Teste>();
            foreach (Teste t in testeTema)
            {
                if (t.GrauDif == u.GrauDif) testeGrau.Add(t);
            }
            sessao.Testes = testeGrau;
            sessao.Tema = tem;
            sessao.Utilizador = u;
            sessao.AulasVistas= new List<Aula> ();;
            sessao.ExerciciosResolvidos= new List<Exercicio> ();;
            sessao.TestesResolvidos = new List<Teste>();
            //sessao.Date
            u.NrSessoesEstudo++;
            u.SessaoEstudo.Add(sessao);
        }

        public float PAulasAssistidas(SessaoEstudo se) {
            float percentagem;
            percentagem = se.AulasVistas.Count / se.Aulas.Count;
            return percentagem;
        }

        public float PExerciciosResolvidos(SessaoEstudo se)
        {
            float percentagem;
            percentagem = se.ExerciciosResolvidos.Count / se.Exercicios.Count;
            return percentagem;
        }

        public float PTestesResolvidos(SessaoEstudo se)
        {
            float percentagem;
            percentagem = se.TestesResolvidos.Count / se.Testes.Count;
            return percentagem;
        }

    }
}
