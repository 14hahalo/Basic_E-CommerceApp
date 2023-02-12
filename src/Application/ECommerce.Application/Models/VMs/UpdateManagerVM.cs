using ECommerce.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace ECommerce.Application.Models.VMs
{
    public class UpdateManagerVM
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? UpdateDate => DateTime.Now;
        public Status Status => Status.Modified;
        public Roles Roles => Roles.Manager;
        public string? ImagePath { get; set; }
        public IFormFile UploadPath { get; set; }
    }
}
