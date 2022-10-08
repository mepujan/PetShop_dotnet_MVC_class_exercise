using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleTest.Models
{
    public class Property
    {

        /*
         * Make the Address, isForSale, and Price required 
         * Restrict the Address to a maximum length of 100 characters
         * Using PositiveNumberAttribute, restrict Price to only positive numbers
         * Using the Properties/CheckCityName action, validate the City passes validation
         */

        public int ID { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public bool isForSale { get; set; }

        public ApplicationUser Owner { get; set; }

        public double Price { get; set; }

    }
}