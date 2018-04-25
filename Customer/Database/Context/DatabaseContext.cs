using Database.Models;
using System.Data.Entity;

namespace Database.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerDetail> CustomerDetails { get; set; }

        public DbSet<Classification> Classifications { get; set; }

        public DbSet<ClientType> ClientTypes { get; set; }

        public DbSet<User> Users { get; set; }

        


    }
}