using WebApplication1.Models;

namespace WebApplication1.DTOs
{
    public class CategoryShowDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CategoryShowDTO() { }

        public CategoryShowDTO(Category Category)
        {
            Id = Category.ID;
            Name = Category.Name;
        }
    }
}