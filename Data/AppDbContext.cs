using Microsoft.EntityFrameworkCore;
using EFCoreApp.Model; // Adjust the namespace if your Student class is in a different one
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;

namespace EFCoreApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=StudentDB;user=root;password=Akash@123",
                new MySqlServerVersion(new Version(8, 0, 36))
            );
        }
    }
}
