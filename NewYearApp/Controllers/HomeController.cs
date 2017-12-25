using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewYearApp.Controllers
{
    public class HomeController : Controller
    {
        Movies mv = new Movies();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CodePage()
        {
            return View();
        }
        public ActionResult CodeEntered(string code)
        {
            if (mv.Films.Keys.Contains(code)) {
                return Redirect("~/Home/Present?code=" + code);
            }
            else return Redirect("/Home/CodePage");
            
            
        }
        public ActionResult Present(string code)
        {
            ViewBag.Movie = mv.Films[code];
            return View();
        }

    }
}