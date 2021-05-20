namespace WebApplication1.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? CategoryID { get; set; }
    }
}