using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace Legato.DAL.Validation
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed class ValidateStringNumber : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            try
            {
                var stringNumber = Convert.ToByte(value);
                return Constants.Constants.StringNumbers.Contains(stringNumber);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
