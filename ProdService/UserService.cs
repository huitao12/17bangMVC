using _17bangMVC.Models.Article;
using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdService
{
    public class UserService
    {
        private ArticleRepository articleRepository;
        private UserRepository userRepository;
        public UserService()
        {
            SqlDbContext context = new SqlDbContext();
            articleRepository = new ArticleRepository(context);
            userRepository = new UserRepository(context);
        }

        public void Publish(NewModel model, int currentUserId)
        {
            Article article = new Article
            {
                Title = model.Title,
                Body = model.Body,
            };

            User author = userRepository.Find(currentUserId);

            article.Author = author;
            articleRepository.Save(article);

        }
    }
}
