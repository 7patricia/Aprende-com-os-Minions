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

        public ActionResult Exercicio(int? id)
        {
            var email = User.Identity.GetUserName();

            if (email != "")
            {
                Utilizador user = db.Utilizadores.Where(x => x.Username.Equals(email)).First();
                @ViewBag.username = user.Username;

                Exercicio exercicio = db.Exercicios.Find(id);
                List<Pergunta> todasperguntas = db.Perguntas.ToList();

                List<Pergunta> perguntas = new List<Pergunta>();

                foreach (Pergunta p in todasperguntas)
                {
                    if ((p.Exercicio!=null) && (p.Exercicio.ExercicioID == exercicio.ExercicioID))
                        perguntas.Add(p);
                }

                @ViewBag.perguntas = perguntas;

                @ViewBag.respostas = db.Respostas.ToList();
                
                return View(exercicio);
            }
            else
            {
                return RedirectToAction("Login", "Utilizadors");
            }

        }

        public ActionResult Index()
        {
            var email = User.Identity.GetUserName();

            if (email != "")
            {
                Utilizador user = db.Utilizadores.Where(x => x.Username == email).First();
                @ViewBag.username = user.Username;
              
                int grau = user.GrauDif;
                IList<Exercicio> exercicios = db.Exercicios.Where(x => x.GrauDif == grau).ToList();


                return View(exercicios);
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

        //POST: Exercicios/Terminar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Terminar(Exercicio e)
        {
            var email = User.Identity.GetUserName();

            if (email != "")
            {
                Utilizador user = db.Utilizadores.Where(x => x.Username == email).First();
                @ViewBag.username = user.Username;

                String r1 = e.R1;
                String r2 = e.R2;
                String r3 = e.R3;

                Exercicio exercicio = db.Exercicios.Find(e.ExercicioID);
                List<Pergunta> todasperguntas = db.Perguntas.ToList();
                List<Pergunta> perguntas = new List<Pergunta>();

                foreach (Pergunta p in todasperguntas)
                {
                    if ((exercicio != null) && (p.Exercicio != null) && (p.Exercicio.ExercicioID == exercicio.ExercicioID))
                        perguntas.Add(p);
                }

                if (perguntas.ElementAt(0).RespCerta.Equals(r1))
                {
                    user.NrRespostasCertas++;
                    db.SaveChanges();
                }
                else
                {
                    user.NrRespostasErradas++;
                    db.SaveChanges();
                }


                if (perguntas.ElementAt(1).RespCerta.Equals(r2))
                {
                    user.NrRespostasCertas++;
                    db.SaveChanges();
                }
                else
                {
                    user.NrRespostasErradas++;
                    db.SaveChanges();
                }

                if (perguntas.ElementAt(2).RespCerta.Equals(r3))
                {
                    user.NrRespostasCertas++;
                    db.SaveChanges();
                }
                else
                {
                    user.NrRespostasErradas++;
                    db.SaveChanges();
                }

                user.NrPerguntasResp = user.NrPerguntasResp + 3;
                db.SaveChanges();

                if ((user.NrRespostasCertas / user.NrRespostasErradas > 0.6) && (user.NrPerguntasResp >= 10) && (user.GrauDif == 1)) { user.GrauDif = 2; db.SaveChanges(); }

                if ((user.NrRespostasCertas / user.NrRespostasErradas > 0.8) && (user.NrPerguntasResp >= 30) && (user.GrauDif == 2)) { user.GrauDif = 3; db.SaveChanges(); }

                return RedirectToAction("Index");
                
            }
            else
            {
                return RedirectToAction("Login", "Utilizadors");
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

       /** public List<string> URLPerguntas(String urlI) {
            List<string> urls = new List<string>();
            Exercicio e = (Exercicio)(db.Exercicios.Where(x => x.URLImagem == urlI));
           ´ IQueryable<Pergunta> perguntas = db.Perguntas.Where(x => x.Exercicio_ExercicioID.Equals(e.ExercicioID));
            foreach(Pergunta p in perguntas) {
                urls.Add(p.URLImagem);
                  }
            return urls;
        }**/

        /*public List<string> RespPergunta(Pergunta p)
        {
            List<string> respString = new List<string>();
            ICollection<Resposta> resp = p.Respostas;
            foreach (Resposta r in resp)
            {
                respString.Add(r.Descricao);
            }
            return respString;
        }*/
        
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
