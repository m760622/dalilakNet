using System;
using Microsoft.EntityFrameworkCore;

namespace dalilak.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; Initial catalog=Dalilak1; User=sa; Password=myPassw0rd; MultipleActiveResultSets=True;");
        }
    }
}
