﻿using SampleTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleTest.Services
{
    public class PropertyService
    {
        public PropertyService()
        {

        }

        public bool CanBuyHouse(Property property, string country)
        {
            //Return true if property's Country property is the same as the country parameter, return false otherwise
            return property.Country.Equals(country);
        }
    }
}