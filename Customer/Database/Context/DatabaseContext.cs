using Database.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;

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

        public int SaveChanges(int userId)
        {
            var selectedEntityList = ChangeTracker.Entries()
                                    .Where(x => x.Entity is BaseModel &&
                                    (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in selectedEntityList)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseModel)entity.Entity).CreatedOn = DateTime.Now;
                    ((BaseModel)entity.Entity).CreatedBy = userId;
                    ((BaseModel)entity.Entity).Version++;
                }
                if (!((BaseModel)entity.Entity).Version.HasValue)
                    ((BaseModel)entity.Entity).Version = 1;
                ((BaseModel)entity.Entity).ModifyOn = DateTime.Now;
                ((BaseModel)entity.Entity).ModifyBy = userId;
            }
            return base.SaveChanges();
        }

    }
}