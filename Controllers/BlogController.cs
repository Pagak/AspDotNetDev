using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            List<Article> lesArticles = new List<Article>()
            {
                new Article(){Title = "Un article", Content = "Son contenu"},
                new Article(){Title = "Un article", Content = "Son contenu"},
                new Article(){Title = "Un article", Content = "Son contenu"},
                new Article(){Title = "Un article", Content = "Son contenu"},
                new Article(){Title = "Un article", Content = "Son contenu"}
            };

            ViewBag.Articles = lesArticles;
            return View();
        }
    }
}