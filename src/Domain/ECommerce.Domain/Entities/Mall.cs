using ECommerce.Domain.Enums;

namespace ECommerce.Domain.Entities
{
    public class Mall : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate {get;set;}
        public DateTime? DeleteDate {get;set;}
        public DateTime? UpdateDate {get;set;}
        public Status Status {get;set;}
        public List<Employee> Employees { get; set; }
        public Mall()
        {
            Employees = new List<Employee>();
        }
    }
}