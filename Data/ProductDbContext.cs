using System;
using Domain;
using System.Data.Entity;

namespace Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("Name=ProductDb")
        {
            Database.SetInitializer<ProductDbContext>(new CreateDatabaseIfNotExists<ProductDbContext>());
            Database.Initialize(false);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Loja> Lojas { get; set; }
    }
}
