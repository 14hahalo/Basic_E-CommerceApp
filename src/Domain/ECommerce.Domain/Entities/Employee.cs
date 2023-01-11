using ECommerce.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities
{
    public class Employee : IBaseEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime BirthDate { get; set; }
        public Status Status { get; set; }
        public Roles Role { get; set; }
        [NotMapped]
        public IFormFile UploadPath { get; set; }
        public string? ImagePath { get; set; }
        //Navigation Property
        public Guid? MallId { get; set; }
        public Mall? Mall { get; set; }
        //Navigation Property for managers
        public Guid? ManagerId { get; set; }
        public Employee? Manager { get; set; }
        public List<Employee> Employees { get; set; }
        public Employee()
        {
            Employees = new List<Employee>();
        }
    }
}
