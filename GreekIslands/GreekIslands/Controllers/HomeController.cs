using System.Linq;
using System.Web.Mvc;
using System.

namespace GreekIslands.Controllers
{
    public class HomeController : Controller
    {
        private IslandsModelEntities db = new IslandsModelEntities();
        public ActionResult Index()
        {
            var islands = 
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