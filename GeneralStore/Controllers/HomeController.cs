using GeneralStoreCore;
using GeneralStoreCore.Models;
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

		[HttpGet]
		public ActionResult NewGame()
		{
			return View();
		}

		public ActionResult NewGame(GameSettingsModel gsModel)
		{
			var saveGame = new GameStorage();

			saveGame.gameSettingsModel = gsModel;

			var store = new Store();



			return RedirectToAction("Index", "Game", null);
		}

		public ActionResult Continue()
		{

			//Load saved game data

			return RedirectToAction("Index", "Game", null);
		}
    }
}