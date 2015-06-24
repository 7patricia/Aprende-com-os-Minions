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
    public class TestesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Testes
        public ActionResult Index()
        {
            var email = User.Identity.GetUserName();

            if (email != "")
            {
                Utilizador user = db.Utilizadores.Where(x => x.Username == email).First();
                @ViewBag.username = user.Username;

                int grau = user.GrauDif;
                IList<Teste> testes = db.Testes.Where(x => x.GrauDif == grau).ToList();


                return View(testes);
            }
            else
            {
                return RedirectToAction("Login", "Utilizadors");
            }
        }

        // GET: Testes/Details/5
        public ActionResult Teste(int? id)
        {
            var email = User.Identity.GetUserName();

            if (email != "")
            {
                Utilizador user = db.Utilizadores.Where(x => x.Username.Equals(email)).First();
                @ViewBag.username = user.Username;

                Teste teste = db.Testes.Find(id);
                List<Pergunta> todasperguntas = db.Perguntas.ToList();

                List<Pergunta> perguntas = new List<Pergunta>();

                foreach (Pergunta p in todasperguntas)
                {
                    if ((p.Teste != null) && (p.Teste.TesteID == teste.TesteID))
                        perguntas.Add(p);
                }

                @ViewBag.perguntas = perguntas;

                @ViewBag.respostas = db.Respostas.ToList();

                return View(teste);
            }
            else
            {
                return RedirectToAction("Login", "Utilizadors");
            }
        }

        // GET: Testes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Testes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TesteID,DataRealizacao,Classificacao,Tema")] Teste teste)
        {
            if (ModelState.IsValid)
            {
                db.Testes.Add(teste);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teste);
        }

        // GET: Testes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teste teste = db.Testes.Find(id);
            if (teste == null)
            {
                return HttpNotFound();
            }
            return View(teste);
        }

        // POST: Testes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TesteID,DataRealizacao,Classificacao,Tema")] Teste teste)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teste).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teste);
        }

        // GET: Testes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teste teste = db.Testes.Find(id);
            if (teste == null)
            {
                return HttpNotFound();
            }
            return View(teste);
        }

        // POST: Testes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Teste teste = db.Testes.Find(id);
            db.Testes.Remove(teste);
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


        //POST: Testes/Terminar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Terminar(Teste e)
        {
            var email = User.Identity.GetUserName();

            if (email != "")
            {
                Utilizador user = db.Utilizadores.Where(x => x.Username == email).First();
                @ViewBag.username = user.Username;

                String r1 = e.R1;
                String r2 = e.R2;
                String r3 = e.R3;

                Teste teste = db.Testes.Find(e.TesteID);
                List<Pergunta> todasperguntas = db.Perguntas.ToList();
                List<Pergunta> perguntas = new List<Pergunta>();

                foreach (Pergunta p in todasperguntas)
                {
                    if ((teste != null) && (p.Teste != null) && (p.Teste.TesteID == teste.TesteID))
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
                user.NrTestesRealizados++;
                db.SaveChanges();

                return RedirectToAction("Index");

            }
            else
            {
                return RedirectToAction("Login", "Utilizadors");
            }

        }

        public List<string> ImagemTeste(Utilizador u)
        {
            List<Teste> testes = new List<Teste>();
            List<string> urls = new List<string>();
            int grau = u.GrauDif;
            testes = db.Testes.Where(x => x.GrauDif == grau).ToList();
            foreach (Teste t in testes)
            {
                urls.Add(t.URL);
            }
            return urls;
        }

        public List<string> ImagemTesteG(Utilizador u, string t)
        {
            List<string> urls = new List<string>();
            IQueryable<Teste> testes = db.Testes.Where(x => x.GrauDif == u.GrauDif);
            foreach (Teste tst in testes)
            {
                if (tst.Tema.Equals(t))
                {
                    urls.Add(tst.URL);
                }
            }
            return urls;
        }

        public List<string> URLPerguntas(Teste t)
        {
            List<string> urls = new List<string>();
            List<Pergunta> perguntas = t.Perguntas.ToList();
            foreach (Pergunta p in perguntas)
            {
                urls.Add(p.URLImagem);
            }
            return urls;
        }

       // public List<string> RespPergunta(Pergunta p)
       // {
           // List<string> respString = new List<string>();
          //  ICollection<string> resp = p.Resp;
          //  respString.Add();
       // }

        public int CotacaoTeste(Utilizador u, List<Pergunta> prgs, List<string> resp)
        {
            int cotacao = 0; int i = 0;
            u.NrPerguntasResp += prgs.Count;
            u.NrTestesRealizados++;
            foreach (Pergunta p in prgs)
            {
                if (p.RespCerta.Equals(resp.ElementAt(i)))
                {
                    cotacao += 5;
                    u.NrRespostasCertas++;
                    i++;
                }
                else
                {
                    u.NrRespostasErradas++;
                    i++;
                }
            }
            return cotacao;
        }

    }
}
