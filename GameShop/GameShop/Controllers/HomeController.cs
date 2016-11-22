using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameShop.Models;

namespace GameShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(GameRepository repository, string name, string genre, int year1, int year2, int viorating, int cost, string company)
        {
            if (ModelState.IsValid)
            {
                ViewBag.GenderGames = repository.Games.Where(x => x.Name == name)
                                                      .Where(x => x.Genre == genre)
                                                      .Where(x => year1<x.PublishYear<year2)
                                                      .Where(x => x.ViolenceRating == viorating)
                                                      .Where(XmlSiteMapProvider => )
            }
            else
            { 
}
                return View();
        }



    }
}