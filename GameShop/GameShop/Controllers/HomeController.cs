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

        public ActionResult Search(ViewModel vm)
        {
            var db = new GameContext();
            //ViewModel request = new Models.ViewModel()
            //{
            //    Games = vm.Games,
            //    makis = vm.makis
            //};

            GamePublisher gp = new GamePublisher
            {
                CompanyName = vm.makis,
                CEOName = vm.psomiadis
            };
            
            db.GamePublisher.Add(gp);
            db.Games.Add(vm.Games);
            return View();
        }



    }
}