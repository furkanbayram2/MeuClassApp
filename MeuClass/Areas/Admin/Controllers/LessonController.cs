﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeuClass.Areas.Admin.Controllers
{
    public class LessonController : Controller
    {
        // GET: Admin/Lesson
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddLesson(string number)
        {
            ViewBag.Number = number;
            return View();
        }
        public ActionResult ViewLesson(string number)
        {
            ViewBag.Number = number;
            return View();
        }
    }
}