using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

/// <summary>
/// Verify if email address is valid.
/// </summary>
public class CustomEmailAddressAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            var email = value?.ToString();

            if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return new ValidationResult("不合法的 email 格式");
            }
        }

        return ValidationResult.Success;
    }
}