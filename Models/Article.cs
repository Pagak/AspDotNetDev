using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }
}