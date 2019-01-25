using Microsoft.AspNetCore.Mvc;

namespace DM.CMS.Web.Controllers
{
    public class HomeController : CMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}