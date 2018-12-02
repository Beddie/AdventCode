﻿using Logic;
using Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventOfCode2018.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var day = RenderDay.GetDay(1);
            ViewBag.answer = day;
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