namespace API.Migrations
{
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UserContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
           
            var customers = new List<Customer>
            {
                new Customer(){FirstName="Surya",LastName="Choudhary",CreateDate=new DateTime(2018,4,2),UpdateDate=new DateTime(2018,4,2) },
                new Customer(){FirstName="Sam",LastName="Choudhary",CreateDate=new DateTime(2018,4,2),UpdateDate=new DateTime(2018,4,2) }
            };
            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();
        }
    }
}
