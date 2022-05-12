using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;
using WebAPI_Car_Mechanic_Common.Models;

namespace WebAPI_Car_Mechanic_Server.Repositories
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        private string dbPath = AppDomain.CurrentDomain.BaseDirectory + "\\CustomersDb.MDF";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\mssqllocaldb;Database=CustomersDb;Integrated Security=True;AttachDBFilename=" + dbPath);
        }
    }
}
