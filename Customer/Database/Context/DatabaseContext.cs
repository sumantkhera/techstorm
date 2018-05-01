using Customer.Entities;
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
        public DbSet<Customer.Entities.Customer> Customers { get; set; }
        public DbSet<CustomerDetail> CustomerDetails { get; set; }

        public DbSet<CustomerImage> CustomerImages { get; set; }

        public DbSet<Classification> Classifications { get; set; }

        public DbSet<ClientType> ClientTypes { get; set; }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerDetail>()
                 .HasRequired(e => e.Customer)
                .WithMany(d => d.CustomDetail)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<CustomerImage>()
                .HasRequired(e => e.Customer)
               .WithMany(d => d.CustomImage)
               .HasForeignKey(e => e.CustomerId);
            base.OnModelCreating(modelBuilder);
        }

        public int SaveChanges(int userId)
        {
            var selectedEntityList = ChangeTracker.Entries()
                                    .Where(x => x.Entity is BaseEntities &&
                                    (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in selectedEntityList)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntities)entity.Entity).CreatedOn = DateTime.Now;
                    ((BaseEntities)entity.Entity).CreatedBy = userId;
                    ((BaseEntities)entity.Entity).Version++;
                }
                if (!((BaseEntities)entity.Entity).Version.HasValue)
                    ((BaseEntities)entity.Entity).Version = 1;
                ((BaseEntities)entity.Entity).ModifyOn = DateTime.Now;
                ((BaseEntities)entity.Entity).ModifyBy = userId;
            }
            return base.SaveChanges();
        }

    }
}