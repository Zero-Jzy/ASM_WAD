using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASM_WAD.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext()
            : base("MyConnectionString")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}