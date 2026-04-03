using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class DbConnectionContext : DbContext
    {
        public DbConnectionContext()
        {
        }
        public DbSet<Car> dbCars { get; set; }
        public DbSet<User> dbUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Jeśli nie skonfigurowano go z zewnątrz, użyj tego:
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=myData;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=True;TrustServerCertificate=True");
            }
        }

    } 
}
