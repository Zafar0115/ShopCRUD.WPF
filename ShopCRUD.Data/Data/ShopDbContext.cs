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
        public DbSet<Shop> MyProperty { get; set; }
    }
}
