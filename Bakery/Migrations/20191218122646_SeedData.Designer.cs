﻿// <auto-generated />
using Bakery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bakery.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191218122646_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bakery.Models.Pie", b =>
                {
                    b.Property<int>("PieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PieID");

                    b.ToTable("Pies");

                    b.HasData(
                        new
                        {
                            PieID = 1,
                            Name = "Apple Pie",
                            Price = 12.96m,
                            ShortDescription = "Our famous apple pies"
                        },
                        new
                        {
                            PieID = 2,
                            Name = "Brownie",
                            Price = 5.25m,
                            ShortDescription = "Our famous Brownie"
                        },
                        new
                        {
                            PieID = 3,
                            Name = "Chery Pie",
                            Price = 3.16m,
                            ShortDescription = "Twin Peaks famous Cherry pies"
                        },
                        new
                        {
                            PieID = 5,
                            Name = "Othello Cake",
                            Price = 112.96m,
                            ShortDescription = "Our expensive Othello Cake"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
