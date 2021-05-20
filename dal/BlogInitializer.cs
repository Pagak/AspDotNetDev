using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.dal
{
    public class BlogInitializer : System.Data.Entity.DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext blogContext)
        {
            var categories = new List<Category>
            {
                new Category(){Name = "ASP.NET" },
                new Category(){Name = "ASP.NET MVC" },
                new Category(){Name = "EntityFramework" },
            };
            categories.ForEach(c => blogContext.Categories.Add(c));
            blogContext.SaveChanges();

            var articles = new List<Article>
            {
                new Article(){Title = "Un article", Content = "Son contenu", CategoryID = 1},
                new Article(){Title = "Un article", Content = "Son contenu", CategoryID = 1},
                new Article(){Title = "Un article", Content = "Son contenu", CategoryID = 2},
                new Article(){Title = "Un article", Content = "Son contenu", CategoryID = 3},
                new Article(){Title = "Un article", Content = "Son contenu", CategoryID = 3}
            };

            articles.ForEach(a => blogContext.Articles.Add(a));
            blogContext.SaveChanges();
        }
    }
}