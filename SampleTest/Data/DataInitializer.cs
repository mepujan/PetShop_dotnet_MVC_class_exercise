using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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

            if(!context.Roles.Any(r=>r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };
            }

            var userStore = new UserStore<IdentityUser>(context);
            var userManager = new UserManager<IdentityUser>(userStore);

            ApplicationUser admin = new ApplicationUser();
            admin.Email = "test@test.com";
            admin.UserName = "test@test.com";
            admin.Country = "Canada";
            admin.DateOfBirth = DateTime.Parse("2000-01-01");

            if(userManager.FindByEmail(admin.Email) == null)
            {
                var result = userManager.Create(admin, "testing1234");
                if (result.Succeeded)
                {
                    userManager.AddToRole(admin.Id, "Admin");
                }
            }

            context.Properties.Add(new Property
            {
                Address = "771 highway drive",
                Country = "Canada",
                City = "sarnia",
                isForSale = true,
                Owner = admin,
                Price = 2000
            });



            context.Properties.Add(new Property
            {
                Address = "40 woodside crescent",
                Country = "Canada",
                City = "Brampton",
                isForSale = false,
                Owner = admin,
                Price = 2500
            });


            base.Seed(context);
        }
    }
}