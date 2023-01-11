using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.Extensions
{
    public class PictureFileExtensionAttribute : ValidationAttribute

    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            IFormFile file = value as IFormFile;
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();

                string[] extensions = { "jpg", "jpeg", "png" };
                bool result = extensions.Any(X => X.EndsWith(X));

                if (!result)
                {
                    return new ValidationResult("Format Exception. You must upload your image as .png , .jpg or .jpeg");
                }
            }
            return ValidationResult.Success;
        }
    }
}
