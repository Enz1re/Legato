using System.Web.Mvc;


namespace Legato.Service.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Legato Service";

            return View();
        }
    }
}
