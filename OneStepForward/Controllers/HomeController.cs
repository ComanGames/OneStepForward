using System.Web.Mvc;

namespace OneStepForward.Controllers
{
    public class HomeController : Controller
    {
        [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This application is created to gain more self-discipline";

            return View();
        }

    }
}