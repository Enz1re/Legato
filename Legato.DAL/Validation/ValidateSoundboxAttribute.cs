﻿using System;
using System.Linq;
using Legato.DAL.Util;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;


[assembly: InternalsVisibleTo("Legato.DAL.Tests")]
namespace Legato.DAL.Validation
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed class ValidateSoundboxAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var soundboxName = value as string;
            if (string.IsNullOrEmpty(soundboxName))
            {
                return false;
            }

            return Constants.Constants.SoundboxNames.Contains(soundboxName, new CaseInsensitiveStringEqualityComparer());
        }
    }
}
