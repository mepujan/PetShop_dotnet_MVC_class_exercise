using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleTest.Attributes
{
    public class PositiveNumberAttribute : ValidationAttribute
    {
        //Call the base ValidationAttribute constructor and pass in a custom error message
        public PositiveNumberAttribute()
        {

        }

        public override bool IsValid(object value)
        {
            //Return true if the value parameter is a positive number
            return base.IsValid(value);
        }
    }
}