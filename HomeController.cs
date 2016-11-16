using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorldTour.Models;

namespace WorldTour.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Tickets()
        {
            return View();
        }

        //Quantity will be given by Booking Controller

        public ActionResult TicketQuantity()
        {
            using (WorldModel db = new WorldModel())
            {
                //We are creating a demo Booking 
                var booking = new Booking
                {
                    Quantity = 8,
                    BookingName = "Giorgos Panagopoulos",
                    Email = "gpana@gmail.com"
                };
                db.Booking.Add(booking);
                return View("Tickets");
            }        
        }


        //Here we are going to get input from the user
        //about the details of the passengers
        [HttpPost]
        public ActionResult AddTicketDetails(List<Tickets> lt, int q)
        {
            using (WorldModel db = new WorldModel())
            {
                foreach(var ticket in lt)
                {

                }
            }
            return View("Tickets");
        }
    }
}
