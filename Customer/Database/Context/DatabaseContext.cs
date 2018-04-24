using Database.Models;
using System.Data.Entity;

namespace Database.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerDetails> CustomerDetails { get; set; }


    }
}