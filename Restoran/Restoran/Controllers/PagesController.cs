using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoran.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Booking()
        {
            return View();
        }
        public ActionResult OurTeam()
        {
            return View();
        }
        public ActionResult Testimonial()
        {
            return View();
        }
    }
}