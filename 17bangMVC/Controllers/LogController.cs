using _17bangMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class LogController : Controller
    {
        // GET: Log
        public ActionResult On()
        {
            LogModel model = new LogModel
            {
                Name = "哈哈",
                Password = "1212"
            };
            return View(model);
        }
    }
}