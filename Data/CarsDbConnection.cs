using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class CarsDbConnection : DbContext
    {
        public DbSet<Car> carsDbConnection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=dbCars;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=True;TrustServerCertificate=True");
        }

    } 
}
