using _17bangMVC.Filters;
using _17bangMVC.Models;
using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class RegisterController : Controller
    {
        private UserRepository   userRepository;
        public RegisterController()
        {
            userRepository = new UserRepository();
        }
        // GET: Register
        [ModelErrolTransferFilter]
        public ActionResult Home()
        {
            if (TempData["e"] != null)
            {
                ModelState.Merge(TempData["e"] as ModelStateDictionary);
            }
            return View();
        }
        [HttpPost]
        [ModelErrolTransferFilter]
        public ActionResult Home(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["e"] = ModelState;
                return RedirectToAction(nameof(Home));
            }
            //检查用户名是否重复
            if (userRepository.GetByName(model.Name) != null)
            {
                ModelState.AddModelError("Name", "用户名不能重复");
                return RedirectToAction(nameof(Home));
            }
            User student = new User
            {
                Name = model.Name,
                Password = model.Password
            };
            student.Register();
            int id = userRepository.Save(student);

            return View();
        }
    }
}