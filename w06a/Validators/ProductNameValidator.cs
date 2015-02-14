using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace w06a.Validators
{
    public class ProductNameValidator : ValidationAttribute
    {
        int maxWords;
        public ProductNameValidator(int numberOfWords) : base("{0} contains too many words")
        {
            this.maxWords = numberOfWords;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string[] words = value.ToString().Split();

            if (words.Length > maxWords)
            {
                var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                return new ValidationResult(errorMessage);
            }
            return ValidationResult.Success;
        }

        public override string FormatErrorMessage(string name)
        {
            return base.FormatErrorMessage(name);
        }
    }
}