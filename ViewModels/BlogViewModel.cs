using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class BlogViewModel
    {
        private IList<Article> articles;
        public IList<Article> Articles
        {
            get { return articles; }
            set { articles = value; }
        }

    }
}