using Microsoft.EntityFrameworkCore;

namespace LookupBusiness.Models
{
  public class LookupBusinessContext : DbContext
  {
    public LookupBusinessContext(DbContextOptions<LookupBusinessContext> options)
      : base(options)
      {
      }

      public DbSet<Restaurant> Restaurants { get; set; }
      public DbSet<Shop> Shops { get; set; }

      // protected override void OnMedelCreating(ModelBuilder builder)
      // {
      //   builder.Entity<Restaurant>()
      //     .HasData(
      //       //Restaurant Seed Data: Id, Name, Offerings, NearestIntersection, Pricing
      //     );

      //   builder.Entity<Shop>()
      //     .HasData(
      //       //Shop Seed Data: Id, Name, Offerings, NearestIntersection, Pricing
      //     );
      // }

  }
}


