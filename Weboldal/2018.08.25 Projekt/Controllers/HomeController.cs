using _2018._08._25_Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2018._08._25_Projekt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult UserDetails()
        {
            var bob = new User();
            bob.Name = "Bob";
            bob.BirthDate = new DateTime(2000, 1, 1);
            return View(bob);
        }

        public ActionResult Belep()
        {
           
            return View();
        }

        public ActionResult Index2()
        {

            return View();
        }
    }
}