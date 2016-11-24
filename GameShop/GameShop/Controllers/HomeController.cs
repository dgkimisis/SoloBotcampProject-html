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

        [HttpGet]
        public ActionResult Search()
        {
            GameContext gct = new GameContext();

            SearchViewModel svm1 = new SearchViewModel();

            //Return List size to View
            svm1.Quantity = gct.Games.Count();
        
            //Return list of strings
            svm1.Genre = gct.Games.Select(x => x.Genre).Distinct().ToList();

            //svm1.Genre = gct.Games;                 
            return View(svm1);
        }

        [HttpPost]
        public ActionResult Search(SearchViewModel svm)
        {
                GameContext gct = new GameContext();
                SearchViewModel svm1 = new SearchViewModel();
                svm.Quantity = gct.Games.Count();
                //Optional Linq
                IQueryable<Games> g = gct.Games;
                if (svm.Games.Name != null)
                {
                    g = g.Where(x => x.Name == svm.Games.Name);
                }
                if (svm.Games.PublishYear != null)
                {
                    g = g.Where(x => x.PublishYear == svm.Games.PublishYear);
                }
                if (svm.Games.Genre != null)
                {
                    g = g.Where(x => x.Genre == svm.Games.Genre);
                }
                if (svm.Games.Violence_Rating != null)
                {
                    g = g.Where(x => x.Violence_Rating == svm.Games.Violence_Rating);
                }
                if (svm.Games.Company != null)
                {
                    g = g.Where(x => x.Company == svm.Games.Company);
                }
                //Na prosthesw to .Distrinct()
                var _games = g.ToList();
                return RedirectToAction("Display", _games);
                //return RedirectToAction("Display", _games);
            }

        

        //In this controller we are going to display the results of the search
        public ActionResult Display()
        {
            return View();
        }
    }
}