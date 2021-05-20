using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.dal
{
    public class BlogInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext blogContext)
        {
            var articles = new List<Article>
            {
                new Article(){Title = "Un article", Content = "Son contenu"},
                new Article(){Title = "Un article", Content = "Son contenu"},
                new Article(){Title = "Un article", Content = "Son contenu"},
                new Article(){Title = "Un article", Content = "Son contenu"},
                new Article(){Title = "Un article", Content = "Son contenu"}
            };

            articles.ForEach(a => blogContext.Articles.Add(a));
            blogContext.SaveChanges();
        }
    }
}