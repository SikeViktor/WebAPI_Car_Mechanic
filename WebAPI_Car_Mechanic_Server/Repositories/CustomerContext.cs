using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using WebAPI_Car_Mechanic_Common.Models;

namespace WebAPI_Car_Mechanic_Server.Repositories
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\mssqllocaldb;Database=CustomerDb;Integrated Security=True;");
        }
    }
}
