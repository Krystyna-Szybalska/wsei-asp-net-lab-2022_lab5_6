﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lab5.Migrations
{
    /// <inheritdoc />
    public partial class list : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Created", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 26, 10, 17, 35, 984, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET 6.0.0" },
                    { 2, new DateTime(2022, 11, 26, 10, 17, 35, 984, DateTimeKind.Local).AddTicks(6644), new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "C# 10.0" },
                    { 3, new DateTime(2022, 11, 26, 10, 17, 35, 984, DateTimeKind.Local).AddTicks(6653), new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Java 19" },
                    { 4, new DateTime(2022, 11, 26, 10, 17, 35, 984, DateTimeKind.Local).AddTicks(6659), new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "JavaScript" },
                    { 5, new DateTime(2022, 11, 26, 10, 17, 35, 984, DateTimeKind.Local).AddTicks(6667), new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Node.js" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
