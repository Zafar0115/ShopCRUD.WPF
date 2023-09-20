using Microsoft.EntityFrameworkCore;
using ShopCRUD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCRUD.Data.Data
{
    public class ShopDbContext:DbContext
    {
        private readonly string _conString;
        private readonly string _mysqlVersion;

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        public ShopDbContext(string conString,string mysqlVersion)
        {
            _conString = conString;
            _mysqlVersion = mysqlVersion;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_conString, ServerVersion.Parse($"{_mysqlVersion}"));
        }
    }
}
