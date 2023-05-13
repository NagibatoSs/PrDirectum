using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Pr.Models;

namespace Pr.Attributes
{
    public class BirthDateAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var birthDate = value as DateTime?;
            if (birthDate == null || birthDate.Value.Date > DateTime.Today)
                return false;
            return true;

        }
    }
}
