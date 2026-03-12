using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace BaseballStatSearchMVC.Controllers
{
    public class TeamController : Controller
    {
        // GET: /Team/
        public ActionResult Index()
        {
            return View();
        }

        //GET: /Team/Welcome/
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}
