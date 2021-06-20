using _17bangMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Home()
        {
            if (TempData["e"]!=null)
            {
                ModelState.Merge(TempData["e"] as ModelStateDictionary);
            }

            RegisterModel model = new RegisterModel
            {
                Name = "下来"
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Home(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["e"] = ModelState;
                return RedirectToAction(nameof(Home));
            }
            return View();
        }
    }
}