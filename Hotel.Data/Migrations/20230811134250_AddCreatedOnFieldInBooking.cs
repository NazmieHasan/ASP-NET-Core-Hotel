using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Data.Migrations
{
    public partial class AddCreatedOnFieldInBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 42, 48, 583, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CategoryId", "Number" },
                values: new object[,]
                {
                    { new Guid("231c33eb-831a-41d3-bad2-57f3dcd1ce20"), 1, 202 },
                    { new Guid("2c5889ae-e556-4365-83b5-7ec305ca6f32"), 1, 205 },
                    { new Guid("57b88b70-15a2-4dee-b5c2-4912917c4881"), 1, 204 },
                    { new Guid("a55d6209-3e1b-4870-a10f-e997701511cc"), 1, 203 },
                    { new Guid("b0cbe165-e804-446b-b0a6-d4ca5b092b36"), 1, 201 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("231c33eb-831a-41d3-bad2-57f3dcd1ce20"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2c5889ae-e556-4365-83b5-7ec305ca6f32"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("57b88b70-15a2-4dee-b5c2-4912917c4881"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a55d6209-3e1b-4870-a10f-e997701511cc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b0cbe165-e804-446b-b0a6-d4ca5b092b36"));

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Bookings");

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
    }
}
