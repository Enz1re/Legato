using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;


[assembly: InternalsVisibleTo("Legato.DAL.Tests")]
namespace Legato.DAL.Validation
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed class ValidateStringNumberAttribute : ValidationAttribute
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
