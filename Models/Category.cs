using DewiMVC.Models.Common;

namespace DewiMVC.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        
        public List<Product>? Products { get; set; }
    }
}
