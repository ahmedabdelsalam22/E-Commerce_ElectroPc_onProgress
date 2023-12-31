﻿// <auto-generated />
using ElectroPc_DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectroPc_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231129124309_modifyProductTbl")]
    partial class modifyProductTbl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ElectroPc_Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<double>("BatteryLifeHours")
                        .HasColumnType("float");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dimensions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayResolution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DisplaySizeInches")
                        .HasColumnType("float");

                    b.Property<string>("GraphicsCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingSystem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RamSizeGB")
                        .HasColumnType("int");

                    b.Property<int>("StorageCapacityGB")
                        .HasColumnType("int");

                    b.Property<string>("StorageType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WeightKg")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            BatteryLifeHours = 6.5,
                            Brand = "Brand 1",
                            Dimensions = "15 x 10 x 1 inches",
                            DisplayResolution = "1920x1080",
                            DisplaySizeInches = 15.6,
                            GraphicsCard = "Graphics Card 1",
                            Name = "Product 1",
                            OperatingSystem = "Windows 10",
                            Processor = "Processor 1",
                            RamSizeGB = 8,
                            StorageCapacityGB = 256,
                            StorageType = "SSD",
                            WeightKg = 1.8
                        },
                        new
                        {
                            ProductId = 10,
                            BatteryLifeHours = 8.0,
                            Brand = "Brand 10",
                            Dimensions = "13 x 9 x 1 inches",
                            DisplayResolution = "1366x768",
                            DisplaySizeInches = 14.0,
                            GraphicsCard = "Graphics Card 10",
                            Name = "Product 10",
                            OperatingSystem = "Windows 10",
                            Processor = "Processor 10",
                            RamSizeGB = 16,
                            StorageCapacityGB = 512,
                            StorageType = "HDD",
                            WeightKg = 2.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
