namespace MVC_Introduction.Models
{
    public class GetProductsViewModel : BaseEntity
    {
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string PhotoUrl { get; set; }
    }
}
