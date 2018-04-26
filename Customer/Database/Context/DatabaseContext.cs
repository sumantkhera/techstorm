using Database.Models;
using System.Data.Entity;

namespace Database.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerDetail> CustomerDetails { get; set; }

        public DbSet<Classification> Classifications { get; set; }

        public DbSet<ClientType> ClientTypes { get; set; }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerDetail>()
                 .HasRequired(e => e.Customer)
                .WithMany(d => d.CustomDetail)
                .HasForeignKey(e => e.CustomerId);
            base.OnModelCreating(modelBuilder);
        }

    }
}