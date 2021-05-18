using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class BlogViewModel
    {
        public IList<Article> Articles { get; set; }

        public BlogViewModel() 
        {
            Articles = new List<Article>();
        }

    }
}