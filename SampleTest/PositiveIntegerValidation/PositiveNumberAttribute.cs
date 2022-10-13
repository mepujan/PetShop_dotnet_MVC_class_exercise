using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleTest.PositiveIntegerValidation
{
    public class PositiveNumberAttribute : ValidationAttribute
    {
        
        private readonly int _minValue;

        public PositiveNumberAttribute(int minValue) : base("Cannot be Negative Value")
        {
            this._minValue = minValue;
        }

        public override bool IsValid(object value)
        {
            return (int)value > this._minValue;
        }
    }
}