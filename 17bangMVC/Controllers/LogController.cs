using _17bangMVC.Models;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class LogController : Controller
    {
        private UserRepository userRepository;
        public LogController()
        {
            SqlDbContext context = new SqlDbContext();
            userRepository = new UserRepository(context);
        }

        // GET: Log
        public ActionResult On()
        {
            if (TempData["e"] != null)
            {
                ModelState.Merge(TempData["e"] as ModelStateDictionary);
            }


            HttpCookie cookie = new HttpCookie("LogOn");
            cookie.Expires = DateTime.Now.AddDays(14);
            Response.Cookies.Add(cookie);

            return View();
        }

        [HttpPost]
        public ActionResult On(LogModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["e"] = ModelState;
                return RedirectToAction(nameof(On));
            }

            if (userRepository.GetByName(model.Name).ToString() != model.Name)
            {
                ModelState.AddModelError(nameof(model.Name), "用户名不存在");
                return View();
            }

            if (userRepository.GetByName(model.Password).ToString() != model.Password)
            {
                ModelState.AddModelError(nameof(model.Password), "用户名或密码输入错误");
            }
            return View();
        }
    }
}