using _17bangMVC.Models.Article;
using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class ArticleController : Controller
    {
        private ArticleRepository articleRepository;
        private UserRepository userRepository;
        public ArticleController()
        {
            SqlDbContext context = new SqlDbContext();
            articleRepository = new ArticleRepository(context);
            userRepository = new UserRepository(context);

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
            Article article = new Article
            {
                Title = model.Title,
                Body = model.Body,
            };

            User author = userRepository.Find(currentUserId);

            article.Author = author;
            articleRepository.Save(article);

            return View();
        }
    }
}