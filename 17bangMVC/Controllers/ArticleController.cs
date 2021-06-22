using _17bangMVC.Models.Article;
using BLL.Entities;
using BLL.Repositories;
using ProdService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class ArticleController : Controller
    {
        private UserService userService;
        public ArticleController()
        {
            userService = new UserService();
        }
        // GET: Article
        public ActionResult Single()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(NewModel model)
        {
            int currentUserId = 1;
            userService.Publish(model, currentUserId);
            return View();
        }
    }
}