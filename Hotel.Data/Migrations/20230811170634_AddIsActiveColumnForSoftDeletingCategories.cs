using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Data.Migrations
{
    public partial class AddIsActiveColumnForSoftDeletingCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("27fa74d1-10c8-4ac5-a237-538e89866076"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("613df3a4-35c5-44f0-85dc-b55aa90ead7c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("77928bb7-cabf-4ebd-a57f-368e631f7e09"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c862d950-ad11-40f2-b3be-a1ce3923a38a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("dd081e71-d9e1-45e6-b3a3-05595b45b1c2"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CategoryId", "Number" },
                values: new object[,]
                {
                    { new Guid("52b95036-b89f-4024-84fb-d36af71b99c6"), 1, 202 },
                    { new Guid("7cc55e45-c895-4a19-a5e1-9c525892823d"), 1, 203 },
                    { new Guid("869631f6-565c-4adf-b710-ee5196a8dff1"), 1, 201 },
                    { new Guid("96a33601-2c26-44aa-acaa-68605bc327e2"), 1, 204 },
                    { new Guid("a00720d7-625c-4d43-a7e4-3f605e7e8404"), 1, 205 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("52b95036-b89f-4024-84fb-d36af71b99c6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7cc55e45-c895-4a19-a5e1-9c525892823d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("869631f6-565c-4adf-b710-ee5196a8dff1"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("96a33601-2c26-44aa-acaa-68605bc327e2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a00720d7-625c-4d43-a7e4-3f605e7e8404"));

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CategoryId", "Number" },
                values: new object[,]
                {
                    { new Guid("27fa74d1-10c8-4ac5-a237-538e89866076"), 1, 204 },
                    { new Guid("613df3a4-35c5-44f0-85dc-b55aa90ead7c"), 1, 201 },
                    { new Guid("77928bb7-cabf-4ebd-a57f-368e631f7e09"), 1, 205 },
                    { new Guid("c862d950-ad11-40f2-b3be-a1ce3923a38a"), 1, 202 },
                    { new Guid("dd081e71-d9e1-45e6-b3a3-05595b45b1c2"), 1, 203 }
                });
        }
    }
}
