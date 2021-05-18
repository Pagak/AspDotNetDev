using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using WebApplication1.ViewModels.Error;

namespace WebApplication1.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public IList<Article> Articles { get; set; }

        public BlogController()
        {
            Articles = new List<Article>
            {
                new Article(){Id = 1, Title = "Un article", Content = "Son contenu"},
                new Article(){Id = 2, Title = "Un article", Content = "Son contenu"},
                new Article(){Id = 3, Title = "Un article", Content = "Son contenu"},
                new Article(){Id = 4, Title = "Un article", Content = "Son contenu"},
                new Article(){Id = 5, Title = "Un article", Content = "Son contenu"}
            };
        }
        public ActionResult Index()
        {
            var model = new BlogViewModel
            {
                Articles = Articles
            };

            return View(model);
        }

        public ActionResult Show(int? Id)
        {
            try
            {
                var model = new ArticleShowModel();
                if (!Id.HasValue)
                    throw new Exception("L'identifiant est inexistant");

                var article = Articles.FirstOrDefault(x => x.Id == Id.Value);

                if (article == null)
                    throw new Exception("L'article demandé n'existe pas.");

                model.Article = article;
                return View(model);

            }catch(Exception e)
            {
                var model = new ErrorViewModel
                {
                    StatusClass = "warning",
                    Message = e.Message
                };
                return View("/Views/Shared/Error.cshtml", model);
            }

        }
    }
}