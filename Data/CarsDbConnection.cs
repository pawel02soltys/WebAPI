using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class DbConnection : DbContext
    {
        public DbSet<Car> dbCars { get; set; }
        public DbSet<User> dbUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=myData;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=True;TrustServerCertificate=True");
        }

    } 
}
