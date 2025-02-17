﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wsei_asp_net_lab.Models;

#nullable disable

namespace lab5.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BooksId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AuthorsId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("AuthorBook");

                    b.HasData(
                        new
                        {
                            AuthorsId = 1,
                            BooksId = 1
                        },
                        new
                        {
                            AuthorsId = 3,
                            BooksId = 2
                        },
                        new
                        {
                            AuthorsId = 2,
                            BooksId = 3
                        },
                        new
                        {
                            AuthorsId = 2,
                            BooksId = 1
                        });
                });

            modelBuilder.Entity("lab_5.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("last_name");

                    b.Property<string>("PESEL")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT")
                        .HasColumnName("pesel");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Robert",
                            LastName = "Martin",
                            PESEL = "no"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Ewa",
                            LastName = "Kowal",
                            PESEL = "1111111111"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Karol",
                            LastName = "Matrix",
                            PESEL = "2222222222"
                        });
                });

            modelBuilder.Entity("lab_5.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 11, 26, 10, 51, 8, 147, DateTimeKind.Local).AddTicks(7312),
                            ReleaseDate = new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "ASP.NET 6.0.0"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 11, 26, 10, 51, 8, 147, DateTimeKind.Local).AddTicks(7365),
                            ReleaseDate = new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "C# 10.0"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2022, 11, 26, 10, 51, 8, 147, DateTimeKind.Local).AddTicks(7374),
                            ReleaseDate = new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Java 19"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2022, 11, 26, 10, 51, 8, 147, DateTimeKind.Local).AddTicks(7381),
                            ReleaseDate = new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "JavaScript"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2022, 11, 26, 10, 51, 8, 147, DateTimeKind.Local).AddTicks(7388),
                            ReleaseDate = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Node.js"
                        });
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("lab_5.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("lab_5.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
