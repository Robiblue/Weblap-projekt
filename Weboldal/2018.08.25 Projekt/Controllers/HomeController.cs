﻿using _2018._08._25_Projekt.Models;
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

        public ActionResult Index1()
        {
            return View();
        }

        public ActionResult Belep()
        {
           
            return View();
        }

        public ActionResult Index2()
        {

            return View();
        }

        public ActionResult Js()
        {

            return View();
        }

        public ActionResult Pr()
        {

            return View();
        }

        public ActionResult Iszgy()
        {

            return View();
        }

        public ActionResult C()
        {

            return View();
        }

        public ActionResult HL()
        {

            return View();
        }
    }
}