using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Validator
{
    public class GmailOrEmailValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string email)
            {
                if (email.Contains("@gmail.com") || email.Contains("@yahoo.com"))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("The username must be a valid email. Ex: '@gmail.com'");
        }
    }
}
