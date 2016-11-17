using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tour.Models;

namespace WorldTour.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Tickets()
        {
            return View();
        }


        //Quantity will be given by Booking Controller
        public ActionResult SampleBooking(int quantity)
        {
            using (TourContext db = new TourContext())
            {
                //We create a demo booking 
                var booking = new Booking()
                {
                    Quantity = 8,
                    BookingName = "Giorgos Panagopoulos",
                    Email = "gpana@gmail.com"
                };
                //db.Bookings.Add(booking);

                //We pass quantity to view
                quantity = booking.Quantity;
                ViewBag.Q = quantity;



                return View();
            }
        }

        //Here we are going to get input from the user
        //about the details of the passengers
        [HttpPost]
        public ActionResult AddTicketDetails(Ticket t)
        {
            using (TourContext db = new TourContext())
            {
                for (int i = 0; i < 7; i++)
                {
                    var ticket = new Ticket { TicketName = t.TicketName, Class = t.Class };
                    db.Tickets.Add(ticket);
                    db.SaveChanges();
                }
                return View("Tickets");
            }
        }
    }
}
