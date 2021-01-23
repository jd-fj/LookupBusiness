using Microsoft.EntityFrameworkCore.Migrations;

namespace LookupBusiness.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Name", "NearestIntersection", "Offerings", "Pricing" },
                values: new object[,]
                {
                    { 1, "Ezelle's", "4th and Ranier Ave S.", "Fried chicken and comfort treats", 2 },
                    { 2, "Pho 99", "Cherry St. and Walnut Pl", "Vietnamese cuisine", 1 },
                    { 3, "Belle's Teryaki", "12th and Jackson", "Seattle style teryaki", 4 },
                    { 4, "Canlis", "Aurora and Canal St.", "Food for the bougeois", 5 },
                    { 5, "Both Ways Cafe", "Lanette and Bulbury Way", "LGBTQ+ friendly cafe with breakfast options", 3 },
                    { 6, "Sicks and stones", "Monkey Puzzle Place and Jefferson Ave N", "Fancy cuisine made over an open flame", 5 }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Name", "NearestIntersection", "Offerings", "Pricing" },
                values: new object[,]
                {
                    { 1, "Ballard Consignment", "20th Ave NW and NW 49th St", "Whimsical store carrying used furniture, art, lighting, housewares, clothing and more", 5 },
                    { 2, "Lucca Gifts", "Ballard Ave NW and Shilshole Ave NW", "Offering an array of handmade gifts, paper art, vintage home goods, and unique curios", 5 },
                    { 3, "Ballyhoo Curiosity Shop", "NW 56th and 24th Ave NW", "Home goods, unique vintage trinkets, handmade coiture", 3 },
                    { 4, "Prism", "20th Ave NW and NW Lone Pl", "Lofty, mod boutique featuring an eclectic range of his&hers apparel", 2 },
                    { 5, "Gold Dogs", "Never St and Going To Happen St", "Pristine condition used vinyl store with unbeatable prices", 1 },
                    { 6, "Home Comforts", "University Way SE and Etta St SE", "Comforts...for your home", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 6);
        }
    }
}
