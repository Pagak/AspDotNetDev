using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.dal;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using WebApplication1.ViewModels.Error;

namespace WebApplication1.Controllers
{
    public class BlogController : Controller
    {

        private readonly BlogContext db = new BlogContext();

        // GET: Blog
        public ActionResult Index()
        {
            var model = new BlogViewModel
            {
                Articles = db.Articles.ToList()
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

                var article = db.Articles.Find(Id.Value);    
                model.Article = article ?? throw new Exception("L'article demandé n'existe pas.");

                var category = db.Categories.Find(article.CategoryID);

                model.Category = category;

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