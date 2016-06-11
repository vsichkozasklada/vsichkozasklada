using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Web.Validators
{
    public class CustomIntValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int initial = 0;
            string errorMsg = "Въведедте валиден размер в сантиметри";
            
            if (value != null)
            {
                var result = Int32.TryParse(value.ToString(), out initial);

                if (result)
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult(errorMsg);
            }
            else if (value == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(errorMsg);
        }
    }
}