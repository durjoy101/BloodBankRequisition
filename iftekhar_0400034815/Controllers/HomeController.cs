using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iftekhar_0400034815.Models;

namespace iftekhar_0400034815.Controllers
{
    public class HomeController : Controller
    {
        iftekhar_0400034815Entities db = new iftekhar_0400034815Entities();
        public ActionResult Index()
        {
            var req = db.Requests.OrderByDescending(r => r.ReqID).ToList().Take(3);
            ViewBag.request = req;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}