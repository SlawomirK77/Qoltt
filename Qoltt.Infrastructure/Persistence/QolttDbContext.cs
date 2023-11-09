using Microsoft.EntityFrameworkCore;
using qoltt.Domain.Entities;

namespace qoltt.Infrastructure.Persistence
{
    public class QolttDbContext : DbContext
    {
        public QolttDbContext(DbContextOptions<QolttDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Tip> Tips { get; set; }
        public DbSet<ItemUri> Uris { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
