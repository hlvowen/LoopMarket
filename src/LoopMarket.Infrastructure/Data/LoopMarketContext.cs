using LoopMarket.Domain.Entity.Catalog;
using LoopMarket.Domain.Entity.Library;
using LoopMarket.Domain.Entity.SocialMarketplace;
using Microsoft.EntityFrameworkCore;

namespace LoopMarket.Infrastructure.Data;

public class LoopMarketContext : DbContext
{
    public DbSet<ItemSubCategory> ItemSubCategories { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Offer> Offers { get; set; }
    public LoopMarketContext(DbContextOptions options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}