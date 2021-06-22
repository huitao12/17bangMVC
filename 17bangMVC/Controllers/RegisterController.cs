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
        private UserRepository userRepository;
        public RegisterController()
        {
            SqlDbContext context = new SqlDbContext();
            userRepository = new UserRepository(context);
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
                //return View(model);
                TempData["e"] = ModelState;
                return RedirectToAction(nameof(Home));
            }

            if (userRepository.GetByName(model.InvitedBy) == null)
            {
                ModelState.AddModelError(nameof(model.InvitedBy), "邀请人不存在");
            }

            if (userRepository.GetByName(model.InviteByCode) == null)
            {
                ModelState.AddModelError(nameof(model.InviteByCode), "邀请人得邀请码错误");
            }

            //检查用户名是否重复
            if (userRepository.GetByName(model.Name) != null)
            {
                ModelState.AddModelError(nameof(model.Name), "用户名不能重复");
                //return RedirectToAction(nameof(Home));
            }

            if (model.ComfirmPassword != model.Password)
            {
                ModelState.AddModelError(nameof(model.ComfirmPassword), "两次输入的密码不一致");
            }

            User user = new User
            {
                Name = model.Name,
                Password = model.Password
            };

            user.Register();
            int id = userRepository.Save(user);

            return View();
        }
    }
}