using OdeToFood.Data.Services;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class HomeController : Controller
    {
        IRestaurantData db;

        /// <summary>
        /// Ajout d'un constructeur pour implémenter l'interface du MODEL
        /// </summary>
        public HomeController(IRestaurantData db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        //A titre d'exemple, on peut utiliser une chaine en retour à la place d'une View
        //public string Index()
        //{
        //    return "Hello World!";
        //}

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