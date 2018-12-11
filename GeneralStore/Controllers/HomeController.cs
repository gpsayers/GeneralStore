using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralStore.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult NewGame()
		{
			return View();
		}

		public ActionResult Continue()
		{
			return RedirectToAction("Index", "Game", null);
		}
    }
}