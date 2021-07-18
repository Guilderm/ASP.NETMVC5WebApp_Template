using System.Web.Mvc;

namespace MVC5WebApp_Template.Controllers
{
    public class MainController : Controller
    {
        public ActionResult FrontPage()
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