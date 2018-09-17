using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Introduction.ValidationAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class PositivePriceValueAttribute : ValidationAttribute, IClientValidatable
    {
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {

            var mvr = new ModelClientValidationRule
            {
                ErrorMessage = ErrorMessage,
                ValidationType = "positivepricevalue"
            };

            return new[] { mvr };
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if (int.TryParse(value.ToString(), out int price))
                {
                    if (price > 0)
                        return ValidationResult.Success;
                    else
                        return new ValidationResult("The price need to be positive");
                }
            }
            return new ValidationResult("Value is null");
        }
    }
}