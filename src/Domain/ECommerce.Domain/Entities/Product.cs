using ECommerce.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities
{
    public class Product : IBaseEntity
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Status Status { get; set; }
        [NotMapped]
        public IFormFile UploadPath { get; set; }
        public string ImagePath { get; set; }
        public List<Category> Categories { get; set; }
        public Product()
        {
            Categories = new List<Category>();
        }
    }
}
