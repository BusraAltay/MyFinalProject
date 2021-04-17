using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje class'larını bağlamak
    public class NorthwindContext : DbContext
    {
        //OnConfiguring : projenin hangi Db ile ilişkili olduğunu belirteceğimiz yer.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-QSKSOIH; Database=Northwind; Trusted_Connection=true");
        }
        //Aşağıdaki kodu Büşra ekledi :)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasNoKey();
        }

        //Hangi class hangi Db tablosuna bağlı
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
