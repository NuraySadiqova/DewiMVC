using DewiMVC.Models.Common;

namespace DewiMVC.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryId { get; set; }
        public Category? Categories { get; set; }
    }
}
