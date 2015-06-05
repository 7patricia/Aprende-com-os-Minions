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
    public class ExerciciosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Exercicios
        public ActionResult Index()
        {
            var email = User.Identity.GetUserName();

            if (email != "")
            {
                Utilizador user = db.Utilizadores.Where(x => x.Username == email).First();
                @ViewBag.username = user.Username;
                @ViewBag.imgEx = UrlExercicio(user);
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Utilizadors");
            }
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


        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        public List<string> UrlExercicio(Utilizador u)
        {
            List<string> urls = new List<string>();
            IQueryable<Exercicio> exs = db.Exercicios.Where(x => x.GrauDif == u.GrauDif);
            foreach (Exercicio e in exs)
            {
                urls.Add(e.URLImagem);
            }

            return urls;
        }
        
        public List<string> ImagemExercicioG(Utilizador u, string t) {
            List<string> urls = new List<string>();
            IQueryable<Exercicio> exs = db.Exercicios.Where(x => x.GrauDif == u.GrauDif);
            foreach (Exercicio e in exs) {
                if (e.Tema.Equals(t)) {
                    urls.Add(e.URLImagem);
                }
            }
            return urls;
        }

        public List<string> URLPerguntas(Exercicio exs) {
            List<string> urls = new List<string>();
            List<Pergunta> perguntas = exs.Perguntas.ToList();
            foreach(Pergunta p in perguntas) {
                urls.Add(p.URLImagem);
                  }
            return urls;
        }

        public List<string> RespPergunta(Pergunta p)
        {
            List<string> respString = new List<string>();
            ICollection<Resposta> resp = p.Respostas;
            foreach (Resposta r in resp)
            {
                respString.Add(r.Descricao);
            }
            return respString;
        }
        
        public int CotacaoEx(Utilizador u,List<Pergunta> prgs, List<string> resp) {
            int cotacao = 0; int i=0;
            u.NrPerguntasResp += prgs.Count;
            foreach (Pergunta p in prgs) {
                if (p.RespCerta.Equals(resp.ElementAt(i)))
                {
                    cotacao += 5;
                    u.NrRespostasCertas++;
                    i++;
                }
                else {
                    u.NrRespostasErradas++;
                    i++;
                }
            }
            return cotacao;
        }


    }
}
