using ECommerce.Application.Extensions;
using ECommerce.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.Models.DTOs
{
    public class AddManagerDTO
    {
        public Guid Id => Guid.NewGuid();
        [Required(ErrorMessage = "You must fill this area.")]
        [MaxLength(25, ErrorMessage = "You can not enter any word that exceeds 25 characters.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "You must fill this area.")]
        [MaxLength(25, ErrorMessage = "You can not enter any word that exceeds 50 characters.")]
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate => DateTime.Now;
        [BirthDateExtension(ErrorMessage = "\r\nYour age must be over 18.")]
        public DateTime BirthDate { get; set; }
        public Status Status => Status.Active;
        public Roles Role => Roles.Manager;
        [PictureFileExtension]
        public IFormFile UploadPath { get; set; }
        public string? ImagePath { get; set; }
    }
}
