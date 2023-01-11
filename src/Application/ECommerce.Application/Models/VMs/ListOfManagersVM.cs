using ECommerce.Domain.Enums;

namespace ECommerce.Application.Models.VMs
{
    public class ListOfManagersVM
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Roles Role { get; set; }
    }
}
