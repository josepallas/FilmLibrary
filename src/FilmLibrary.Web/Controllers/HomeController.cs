using FilmLibrary.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilmLibrary.Web.Controllers
{
    public class HomeController : Controller
    {
        private FilmService filmService;
        public HomeController()
        {
            filmService = new FilmService();
        }
        public ActionResult Index()
        {
            var list = filmService.GetFilms();
            return View();
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