using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Data.Migrations
{
    public partial class FixCreatedOnDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 11, 13, 42, 48, 583, DateTimeKind.Utc).AddTicks(2380));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 13, 42, 48, 583, DateTimeKind.Utc).AddTicks(2380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

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
    }
}
