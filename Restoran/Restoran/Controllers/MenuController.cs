using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restoran.Models.Siniflar;

namespace Restoran.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Menus.ToList();
            return View(degerler);
        }
    }
}