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

        //public ActionResult Search(GameRepository rdb, )
        //{
        //    var games = rdb.Games.Where
        //}

        public ActionResult Search(string name, string genre, int? year1, int? year2, int viorating, int? cost, string company)
        {
            var games = rdb.Games.Where(x => x.Name == name || x.Genre = )
                                 .Where(x => x.Genre == genre)
                                 .Where(x => Enumerable(year1, year2)
                                 .Where(x => x. == genre)
                                 .Where(x => x.Genre == genre)
                                 .Where(x => x.Genre == genre)
                                 .ToList();
            return View(games)
        }

        public ActionResult Display(string name, string genre, int? year1, int? year2, int viorating, int? cost, string company)
        {
            var games = rdb.Games.Where(x => x.Name == name|| x.Genre = )
                                 .Where(x => x.Genre == genre)
                                 .Where(x => Enumerable(year1, year2)
                                 .Where(x => x. == genre)
                                 .Where(x => x.Genre == genre)
                                 .Where(x => x.Genre == genre)
                                 .ToList();
            return View(games)
        }
}