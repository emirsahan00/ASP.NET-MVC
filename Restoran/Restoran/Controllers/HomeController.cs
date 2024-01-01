using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restoran.Models.Siniflar;

namespace Restoran.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Sliders.ToList();
            return View(degerler);
        }

        
        public ActionResult About()
        {
            
            return View(); 
        }

        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Booking()
        {
            return View();
        }

    }
}