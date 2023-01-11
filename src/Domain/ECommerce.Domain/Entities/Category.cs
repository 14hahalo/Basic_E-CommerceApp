using ECommerce.Domain.Enums;

namespace ECommerce.Domain.Entities
{
    public class Category : IBaseEntity
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Status Status { get; set; }
        public List<Product> Products { get; set; }
        public Category()
        {
            Products = new List<Product>();
        }
    }
}
