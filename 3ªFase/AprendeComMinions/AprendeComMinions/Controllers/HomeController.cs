using AprendeComMinions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace AprendeComMinions.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var email = User.Identity.GetUserName();

            if (email != "") {
                Utilizador user = db.Utilizadores.Where(x => x.Username == email).First();
                @ViewBag.username = user.Username;
                return View();
            } else {
                return RedirectToAction("Login", "Utilizadors");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}