﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QAForum.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The UK’s leading learning company.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact QA.";

            return View();
        }
    }
}