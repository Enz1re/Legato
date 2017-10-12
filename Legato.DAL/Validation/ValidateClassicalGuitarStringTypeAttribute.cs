using System;
using System.Linq;
using Legato.DAL.Util;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;


[assembly: InternalsVisibleTo("Legato.DAL.Tests")]
namespace Legato.DAL.Validation
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    class ValidateClassicalGuitarStringTypeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var stringType = value as string;
            if (string.IsNullOrEmpty(stringType))
            {
                return false;
            }

            return Constants.Constants.ClassicalGuitarStringTypes.Contains(stringType, new CaseInsensitiveStringEqualityComparer());
        }
    }
}
