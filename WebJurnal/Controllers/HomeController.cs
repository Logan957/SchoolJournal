using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebJurnal.Models;


namespace WebJurnal.Controllers
{
    public class HomeController : Controller
    {
        JurnalContext db = new JurnalContext();
        public ActionResult Index()
        {
            IEnumerable<Class> cl = db.Classes;
            ViewBag.Classes = cl;
            return View();
        }

       
    }
}