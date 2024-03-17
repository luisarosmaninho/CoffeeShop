using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoffeeShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedProdutoToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, "Smooth espresso with a generous layer of creamy milk foam, sprinkled with cocoa powder for a touch of indulgence.", "https://placehold.co/600x400", "Cappuccino", 2.5, null },
                    { 2, null, "Delicate espresso combined with steamed milk, creating a smooth and balanced beverage, ideal for those who appreciate a mild and creamy coffee.", "https://placehold.co/600x400", "Latte", 3.0, null },
                    { 3, null, "Strong and intense shot of espresso, perfect for those who crave a bold coffee flavor.", "https://placehold.co/600x400", "Espresso", 1.5, null },
                    { 4, null, "Espresso diluted with hot water, resulting in a smooth and light coffee beverage.", "https://placehold.co/600x400", "Americano", 2.0, null },
                    { 5, null, "Espresso with a small amount of steamed milk, providing a touch of smoothness and balance to the intense flavor of the coffee.", "https://placehold.co/600x400", "Macchiato", 2.0, null },
                    { 6, null, "Refreshing coffee served over ice, perfect for hot summer days.", "https://placehold.co/600x400", "Iced Coffee", 3.0, null },
                    { 7, null, "Cold coffee blended with milk, ice, and flavorings, creating a creamy and refreshing beverage.", "https://placehold.co/600x400", "Frappe", 4.0, null },
                    { 8, null, "Our exclusive blend with floral notes and a hint of honey, perfect for those seeking an aromatic experience.", "https://placehold.co/600x400", "Rosmaninho Blend", 3.5, null },
                    { 9, null, "A refreshing combination of espresso and cold milk served over ice, perfect for a hot summer day.", "https://placehold.co/600x400", "Iced Latte", 3.5, null },
                    { 10, null, "Espresso combined with steamed milk and chocolate syrup, topped with whipped cream, for an indulgent coffee treat.", "https://placehold.co/600x400", "Mocha", 4.0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
