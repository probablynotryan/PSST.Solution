using Microsoft.EntityFrameworkCore;

namespace Treats.Models
{
  public class TreatsContext : DbContext
  {
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<Sweet> Sweets { get; set; }
    public DbSet<FlavorSweet> FlavorSweet { get; set; }

    public TreatsContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
