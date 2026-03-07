using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class ListOfUsers : DbContext
    {
        //@"Data Source=localhost;Database=myData;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=True;TrustServerCertificate=True";

        //public ListOfUsers(DbContextOptions<ListOfUsers> options) 
        //    : base(options) { }
        public DbSet<User> dbUsers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=dbUsers;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=True;TrustServerCertificate=True");
            //base.OnConfiguring(optionsBuilder);
        }

    } 
}
