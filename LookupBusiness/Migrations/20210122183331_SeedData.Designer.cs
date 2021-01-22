﻿// <auto-generated />
using LookupBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LookupBusiness.Migrations
{
    [DbContext(typeof(LookupBusinessContext))]
    [Migration("20210122183331_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LookupBusiness.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NearestIntersection")
                        .IsRequired();

                    b.Property<string>("Offerings")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Pricing");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            Name = "Ezelle's",
                            NearestIntersection = "4th and Ranier Ave S.",
                            Offerings = "Fried chicken and comfort treats",
                            Pricing = 2
                        },
                        new
                        {
                            RestaurantId = 2,
                            Name = "Pho 99",
                            NearestIntersection = "Cherry St. and Walnut Pl",
                            Offerings = "Vietnamese cuisine",
                            Pricing = 1
                        },
                        new
                        {
                            RestaurantId = 3,
                            Name = "Belle's Teryaki",
                            NearestIntersection = "12th and Jackson",
                            Offerings = "Seattle style teryaki",
                            Pricing = 4
                        },
                        new
                        {
                            RestaurantId = 4,
                            Name = "Canlis",
                            NearestIntersection = "Aurora and Canal St.",
                            Offerings = "Food for the bougeois",
                            Pricing = 5
                        },
                        new
                        {
                            RestaurantId = 5,
                            Name = "Both Ways Cafe",
                            NearestIntersection = "Lanette and Bulbury Way",
                            Offerings = "LGBTQ+ friendly cafe with breakfast options",
                            Pricing = 3
                        },
                        new
                        {
                            RestaurantId = 6,
                            Name = "Sicks and stones",
                            NearestIntersection = "Monkey Puzzle Place and Jefferson Ave N",
                            Offerings = "Fancy cuisine made over an open flame",
                            Pricing = 5
                        });
                });

            modelBuilder.Entity("LookupBusiness.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NearestIntersection")
                        .IsRequired();

                    b.Property<string>("Offerings")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Pricing");

                    b.HasKey("ShopId");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            ShopId = 1,
                            Name = "Ballard Consignment",
                            NearestIntersection = "20th Ave NW and NW 49th St",
                            Offerings = "Whimsical store carrying used furniture, art, lighting, housewares, clothing and more",
                            Pricing = 5
                        },
                        new
                        {
                            ShopId = 2,
                            Name = "Lucca Gifts",
                            NearestIntersection = "Ballard Ave NW and Shilshole Ave NW",
                            Offerings = "Offering an array of handmade gifts, paper art, vintage home goods, and unique curios",
                            Pricing = 5
                        },
                        new
                        {
                            ShopId = 3,
                            Name = "Ballyhoo Curiosity Shop",
                            NearestIntersection = "NW 56th and 24th Ave NW",
                            Offerings = "Home goods, unique vintage trinkets, handmade coiture",
                            Pricing = 3
                        },
                        new
                        {
                            ShopId = 4,
                            Name = "Prism",
                            NearestIntersection = "20th Ave NW and NW Lone Pl",
                            Offerings = "Lofty, mod boutique featuring an eclectic range of his&hers apparel",
                            Pricing = 2
                        },
                        new
                        {
                            ShopId = 5,
                            Name = "Gold Dogs",
                            NearestIntersection = "Never St and Going To Happen St",
                            Offerings = "Pristine condition used vinyl store with unbeatable prices",
                            Pricing = 1
                        },
                        new
                        {
                            ShopId = 6,
                            Name = "Home Comforts",
                            NearestIntersection = "University Way SE and Etta St SE",
                            Offerings = "Comforts...for your home",
                            Pricing = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
