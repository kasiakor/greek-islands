using GreekIslands.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GreekIslands.Controllers
{
    public class HomeController : Controller
    {
        private IslandsModelsEntities db = new IslandsModelsEntities();
        public ActionResult Index()
        {
            var islands = from i in db.islands
                          select i;
            return View(islands);
        }

        public ActionResult Create()
        {
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