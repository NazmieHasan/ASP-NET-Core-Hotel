#nullable disable

namespace Hotel.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Beds", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 2, "Modern and stylish design for you", "https://cdn.pixabay.com/photo/2020/01/15/18/02/room-4768552_1280.jpg", "Double Room", 200.00m },
                    { 2, 3, "Convenience for all the family", "https://cdn.pixabay.com/photo/2015/10/18/12/06/double-bed-994230_1280.jpg", "Triple Room", 250.00m },
                    { 3, 4, "Modern design, comfort and convenience", "https://cdn.pixabay.com/photo/2014/04/26/00/41/dining-room-332207_1280.jpg", "Apartment", 500.00m },
                    { 4, 2, "Luxury, elegance and comfort", "https://cdn.pixabay.com/photo/2015/04/11/23/25/bed-718311_1280.jpg", "Double Room L", 300.00m },
                    { 5, 4, "Luxury, elegance and comfort", "https://cdn.pixabay.com/photo/2014/04/26/00/41/interior-design-332212_1280.jpg", "Apartment L", 700.00m },
                    { 6, 4, "Super luxury, elegance and comfort", "https://cdn.pixabay.com/photo/2016/01/23/23/52/dining-room-1158266_1280.jpg", "Apartment Super L", 1000.00m }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CategoryId", "Number" },
                values: new object[,]
                {
                    { new Guid("1e45e862-1ea1-4746-8cdb-d9a1082bc076"), 1, 201 },
                    { new Guid("26bb46a2-eded-4754-b132-d20811a007ca"), 1, 204 },
                    { new Guid("83d2dcc3-4ac2-4bbc-bbf4-7277f56c8cf7"), 1, 203 },
                    { new Guid("8db70da9-1b3f-4d27-8d92-348745d3b4de"), 1, 202 },
                    { new Guid("c8477b3b-5d19-4880-a654-6f5fb7051f3d"), 1, 205 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1e45e862-1ea1-4746-8cdb-d9a1082bc076"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("26bb46a2-eded-4754-b132-d20811a007ca"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("83d2dcc3-4ac2-4bbc-bbf4-7277f56c8cf7"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8db70da9-1b3f-4d27-8d92-348745d3b4de"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c8477b3b-5d19-4880-a654-6f5fb7051f3d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
