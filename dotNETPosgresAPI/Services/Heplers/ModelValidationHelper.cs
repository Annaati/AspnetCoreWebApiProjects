using System.ComponentModel.DataAnnotations;

namespace dotNETPosgresAPI.Services.Heplers
{
    public class ModelValidationHelper
    {

        internal static void ValidateModel(object obj)
        {
            ValidationContext validationContext = new ValidationContext(obj);
            List<ValidationResult> validationResults = new List<ValidationResult>();

            bool IsValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);

            if (!IsValid)
                throw new ArgumentException(validationResults.FirstOrDefault()?.ErrorMessage);
        }





    }
}
