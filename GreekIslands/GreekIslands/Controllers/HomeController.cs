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
 
        [HttpPost]
        
        public ActionResult Create(island island)
        {
            if (island.Picture == null)
            {
                island.Picture = "http://photosku.com/images_file/small_images/s005_958.jpg";
            }
            db.islands.Add(island);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }

        public ActionResult Edit(int? id)
        {
            island island = db.islands.Find(id);
            return View(island);
        }

        [HttpPost]
        public ActionResult Edit(island island)
        {
            if (island.Picture == null)
            {
                island.Picture = "http://photosku.com/images_file/small_images/s005_958.jpg";
            }
            db.Entry(island).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            island island = db.islands.Find(id);
            return View(island);
        }

        //public ActionResult Delete ()
        //{
        //    return RedirectToAction("Index");
        //}

        public ActionResult Delete(int id)
        {
            island island = db.islands.Find(id);
            return View(island);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            island island = db.islands.Find(id);
            db.islands.Remove(island);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}