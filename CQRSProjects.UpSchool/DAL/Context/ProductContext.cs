using CQRSProjects.UpSchool.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.DAL.Context
{
    public class ProductContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-8GBIAO0U\\SQLEXPRESS;Database=DbCqrs;integrated security=true");
        }

        public DbSet<Product> Products { get; set; }
    }
}
