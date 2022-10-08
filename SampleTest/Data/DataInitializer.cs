using SampleTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleTest.Data
{
    public class DataInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {

        protected override void Seed(ApplicationDbContext context)
        {

            /*
             * Create an "Admin" Role
             * Create a test user, set their Country to Canada, date of birth to Jan 01 2000, user name and email to test@test.com and password to testing1234
             * Create two Property's, both owned by the test user, but one is for sale, set both countries to Canada
             * */
            base.Seed(context);
        }
    }
}