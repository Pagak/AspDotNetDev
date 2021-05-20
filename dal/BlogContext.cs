using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.dal
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContext")
        { }

        public DbSet<Article> Articles { get; set; }
    }
}