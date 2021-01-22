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

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Restaurant>()
          .HasData(
            new Restaurant { RestaurantId = 1, Name = "Ezelle's", Offerings = "Fried chicken and comfort treats", NearestIntersection = "4th and Ranier Ave S.", Pricing = 2 },
            new Restaurant { RestaurantId = 2, Name = "Pho 99", Offerings = "Vietnamese cuisine", NearestIntersection = "Cherry St. and Walnut Pl", Pricing = 1 },
            new Restaurant { RestaurantId = 3, Name = "Belle's Teryaki", Offerings = "Seattle style teryaki", NearestIntersection = "12th and Jackson", Pricing = 4 },
            new Restaurant { RestaurantId = 4, Name = "Canlis", Offerings = "Food for the bougeois", NearestIntersection = "Aurora and Canal St.", Pricing = 5 },
            new Restaurant { RestaurantId = 5, Name = "Both Ways Cafe", Offerings = "LGBTQ+ friendly cafe with breakfast options", NearestIntersection = "Lanette and Bulbury Way", Pricing = 3 },
            new Restaurant { RestaurantId = 6, Name = "Sicks and stones", Offerings = "Fancy cuisine made over an open flame", NearestIntersection = "Monkey Puzzle Place and Jefferson Ave N", Pricing = 5 }
          );

        builder.Entity<Shop>()
          .HasData(
            new Shop { ShopId = 1, Name = "Ballard Consignment", Offerings = "Whimsical store carrying used furniture, art, lighting, housewares, clothing and more", NearestIntersection = "20th Ave NW and NW 49th St", Pricing = 5 },
            new Shop { ShopId = 2, Name = "Lucca Gifts", Offerings = "Offering an array of handmade gifts, paper art, vintage home goods, and unique curios", NearestIntersection = "Ballard Ave NW and Shilshole Ave NW", Pricing = 5 },
            new Shop { ShopId = 3, Name = "Ballyhoo Curiosity Shop", Offerings = "Home goods, unique vintage trinkets, handmade coiture", NearestIntersection = "NW 56th and 24th Ave NW", Pricing = 3 },
            new Shop { ShopId = 4, Name = "Prism", Offerings = "Lofty, mod boutique featuring an eclectic range of his&hers apparel", NearestIntersection = "20th Ave NW and NW Lone Pl", Pricing = 2 },
            new Shop { ShopId = 5, Name = "Gold Dogs", Offerings = "Pristine condition used vinyl store with unbeatable prices", NearestIntersection = "Never St and Going To Happen St", Pricing = 1 },
            new Shop { ShopId = 6, Name = "Home Comforts", Offerings = "Comforts...for your home", NearestIntersection = "University Way SE and Etta St SE", Pricing = 4 }
          );
      }

  }
}


