using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameShop.Models;
using System.Runtime.InteropServices;

namespace GameShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //In this controller we are receiving the parameters according to which we want to do the game search
        //string name, int? publishyear, string genre, int? viorating, string company

        [HttpPost]
        public ActionResult Search(SearchViewModel svm)
        {
            //if (svm.Game.Name == null && svm.Game.PublishYear == null && svm.Game.Genre == null && svm.Game.Violence_Rating == null && svm.Game.Company == null)
            //{
            //    ModelState.AddModelError("", "You must add criteria to your search");
            //    return View();
            //}
            //else
            //{
                GameContext gct = new GameContext();
            //We need the list of Genres in our view and i pick them from viewmodel
            var games = gct.Games.Select(x => x);
                ViewBag.genres = games.Select(x => x.Genre).Distinct();

                IQueryable<Games> g = gct.Games;

                if (svm.Game.Name != null)
                {
                    g = g.Where(x => x.Name == svm.Game.Name);
                }
                if (svm.Game.PublishYear != null)
                {
                    g = g.Where(x => x.PublishYear == svm.Game.PublishYear);
                }
                if (svm.Game.Genre != null)
                {
                    g = g.Where(x => x.Genre == svm.Game.Genre);
                }
                if (svm.Game.Violence_Rating != null)
                {
                    g = g.Where(x => x.Violence_Rating == svm.Game.Violence_Rating);
                }
                if (svm.Game.Company != null)
                {
                    g = g.Where(x => x.Company == svm.Game.Company);
                }
                //Na prosthesw to .Distrinct()
                var _games = g.ToList();
                return View();
                //return RedirectToAction("Display", _games);
            }

        

        //In this controller we are going to display the results of the search
        public ActionResult Display()
        {
            return View();
        }
    }
}