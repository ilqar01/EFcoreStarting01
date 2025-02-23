using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EntityFrameworkStarting.DataAccessLayer
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP - COFH27A; Initial Catalog = UdemyEFCoreDatabaseFirstDb; Integrated Security = True;" +
                " Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; " +
                "ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }

    }
}
