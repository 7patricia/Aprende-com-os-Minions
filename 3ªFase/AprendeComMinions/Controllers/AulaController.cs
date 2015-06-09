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
    public class AulaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Show(int? id)
        {
        var email = User.Identity.GetUserName();

        if (email != "")
        {
            Utilizador user = db.Utilizadores.Where(x => x.Username.Equals(email)).First();
            @ViewBag.username = user.Username;

            Aula aula = db.Aulas.Find(id);
            
            return View(aula);
        }
        else
        {
            return RedirectToAction("Login", "Utilizadors");
        }

        }
        // GET: Aula
        public ActionResult Index()
        {
            var email = User.Identity.GetUserName();

            if (email != "") {
                Utilizador user = db.Utilizadores.Where(x => x.Username.Equals(email)).First();
                
                int grau = user.GrauDif;
                IList<Aula> aulas = db.Aulas.Where(x => x.GrauDif == grau).ToList();

                @ViewBag.username = user.Username;
               // String urlAulaEsc = Request["src"].ToString();
               // @ViewBag.urlVideoEsc = UrlVideo(urlAulaEsc);

                return View(aulas);
            } else {
                return RedirectToAction("Login", "Utilizadors");
            }

           
        }

        // GET: Aula/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aula aula = db.Aulas.Find(id);
            if (aula == null)
            {
                return HttpNotFound();
            }
            return View(aula);
        }

        // GET: Aula/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aula/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AulaID,Tema,GrauDif")] Aula aula)
        {
            if (ModelState.IsValid)
            {
                db.Aulas.Add(aula);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aula);
        }

        // GET: Aula/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aula aula = db.Aulas.Find(id);
            if (aula == null)
            {
                return HttpNotFound();
            }
            return View(aula);
        }

        // POST: Aula/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AulaID,Tema,GrauDif")] Aula aula)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aula).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aula);
        }

        // GET: Aula/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aula aula = db.Aulas.Find(id);
            if (aula == null)
            {
                return HttpNotFound();
            }
            return View(aula);
        }

        // POST: Aula/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aula aula = db.Aulas.Find(id);
            db.Aulas.Remove(aula);
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

 
        
        public string UrlVideo(string urlI) {
            string urlV;
            Aula a = (Aula)(db.Aulas.Where(x => x.URLImagem == urlI));
            urlV = a.URLVideo;
            return urlV;
        }


 
        public string TituloAula(string urlI) {
            string titulo;
            Aula a = (Aula)(db.Aulas.Where(x => x.URLImagem == urlI));
            titulo = a.Titulo;

            return titulo;
        }

        
    }
}
