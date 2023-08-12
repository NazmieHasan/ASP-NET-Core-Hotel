using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Data.Migrations
{
    public partial class AddUserFirstNameAndLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "Test");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "Testov");

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CategoryId", "Number" },
                values: new object[,]
                {
                    { new Guid("084075b1-6840-41f8-8d30-5f3611027f3e"), 1, 202 },
                    { new Guid("4057b7bb-f30c-436e-a713-9626fcab3bb9"), 1, 203 },
                    { new Guid("ab083b53-c4a2-4457-ba52-94b4f6b31cd6"), 1, 201 },
                    { new Guid("cbaba543-8301-420d-bded-4670f47f79a5"), 1, 205 },
                    { new Guid("f3685318-4a80-4fca-9ea3-e1eb5a6c1fea"), 1, 204 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("084075b1-6840-41f8-8d30-5f3611027f3e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4057b7bb-f30c-436e-a713-9626fcab3bb9"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ab083b53-c4a2-4457-ba52-94b4f6b31cd6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("cbaba543-8301-420d-bded-4670f47f79a5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f3685318-4a80-4fca-9ea3-e1eb5a6c1fea"));

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

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
    }
}
