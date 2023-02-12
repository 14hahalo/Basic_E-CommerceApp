using ECommerce.Application.Extensions;
using ECommerce.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.Models.DTOs
{
    public class UpdateManagerDTO
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Cannot be Empty")]
        [MaxLength(25, ErrorMessage = "You Cannot Enter More Than 25 Characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Cannot be Empty")]
        [MaxLength(50, ErrorMessage = "You Cannot Enter More Than 25 Characters")]
        public string LastName { get; set; }
        public DateTime? UpdateDate => DateTime.Now;
        public Status Status => Status.Modified;
        public Roles Roles => Roles.Manager;
        public string? ImagePath { get; set; }
        [PictureFileExtension]
        public IFormFile UploadPath { get; set; }
    }
}
