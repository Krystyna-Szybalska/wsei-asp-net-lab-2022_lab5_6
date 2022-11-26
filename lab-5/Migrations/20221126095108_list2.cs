using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab5.Migrations
{
    /// <inheritdoc />
    public partial class list2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorsId", "BooksId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 26, 10, 51, 8, 147, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 26, 10, 51, 8, 147, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 26, 10, 51, 8, 147, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 26, 10, 51, 8, 147, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 26, 10, 51, 8, 147, DateTimeKind.Local).AddTicks(7388));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 11, 26, 10, 41, 17, 153, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 11, 26, 10, 41, 17, 153, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 11, 26, 10, 41, 17, 153, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 11, 26, 10, 41, 17, 153, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 11, 26, 10, 41, 17, 153, DateTimeKind.Local).AddTicks(2316));
        }
    }
}
