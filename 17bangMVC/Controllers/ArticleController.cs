﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Single()
        {
            return View();
        }

        //public ActionResult New(int id)
        //{
        //    return View();
        //}
        //[HttpPost]
        public ActionResult New()
        {
            return View();
        }
    }
}