using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthKitService.Annotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class IntegerValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Int32 number;

            if (value == null)
            {
                return true;
            }

            bool isParsed = Int32.TryParse(value.ToString(), out number);
            if (!isParsed)
            {
                return false;
            }
            if (Int32.Parse(value.ToString()) <= 0)
            {
                return false;
            }
            return true;
        }
    }
}