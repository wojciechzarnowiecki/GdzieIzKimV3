﻿using GdzieIzKim.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GdzieIzKim.Controllers
{
    public class HomeController : Controller
    {
        contextDB db = new contextDB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mapa()
        {
            return View();
        }

        public JsonResult GetAll()
        {
            var data = db.Lokalizacje.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult AdminPanel()
        {
            return View();
        }
    }
}