﻿// <auto-generated />
using System;
using EmployeeManagement_system.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagement_system.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManagement_system.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeManagement_system.Models.PublicHoliday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PublicHolidays");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New Year's Day"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Labour Day"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Esala Full Moon (Poya Day)"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nikini Full Moon (Poya Day)"
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Binara Full Moon (Poya Day)"
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Duruthu Full Moon (Poya Day)"
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Christmas Day"
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Boxing Day"
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Mawlid al-Nabi (Prophet Muhammad's Birthday)"
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Eid ul-Fitr"
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Eid ul-Azha"
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Duruthu Poya"
                        },
                        new
                        {
                            Id = 13,
                            Date = new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Navam Poya"
                        },
                        new
                        {
                            Id = 14,
                            Date = new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Madin Poya"
                        },
                        new
                        {
                            Id = 15,
                            Date = new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bak Full Moon Poya"
                        },
                        new
                        {
                            Id = 16,
                            Date = new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Vesak Poya"
                        },
                        new
                        {
                            Id = 17,
                            Date = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Poson Poya"
                        },
                        new
                        {
                            Id = 18,
                            Date = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Esala Poya"
                        },
                        new
                        {
                            Id = 19,
                            Date = new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nikini Poya"
                        },
                        new
                        {
                            Id = 20,
                            Date = new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Binara Poya"
                        },
                        new
                        {
                            Id = 21,
                            Date = new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Duruthu Poya"
                        },
                        new
                        {
                            Id = 22,
                            Date = new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ill Full Moon Poya"
                        },
                        new
                        {
                            Id = 23,
                            Date = new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Unduvap Poya"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
