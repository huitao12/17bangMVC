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
            if (TempData["e"] != null)
            {
                ModelState.Merge(TempData["e"] as ModelStateDictionary);
            }

            LogModel model = new LogModel
            {
                Name = "哈哈",
                Password = "1212"
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult On(int? id ,string name, LogModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["e"] = ModelState;
                return RedirectToAction(nameof(On));
            }
            return View();
        }
    }
}