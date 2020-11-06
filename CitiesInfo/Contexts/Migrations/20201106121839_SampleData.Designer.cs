﻿// <auto-generated />
using Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Contexts.Migrations
{
    [DbContext(typeof(CityInfoContext))]
    [Migration("20201106121839_SampleData")]
    partial class SampleData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "City of Lights",
                            Name = "Karachi"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Orange train wali city",
                            Name = "Lahore"
                        },
                        new
                        {
                            Id = 3,
                            Description = "City of Text Books",
                            Name = "Jamshoro"
                        });
                });

            modelBuilder.Entity("Entities.PlaceToVisit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PlacesToVisit");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Description = "Amusement Park",
                            Name = "Chunky Monkey"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Description = "Mohammad Ali Jinnah Grave",
                            Name = "Mazar e Quaid"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Description = "PMLN's train plan",
                            Name = "Orange Train"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            Description = "red mosque",
                            Name = "Badshahi Mosque"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 2,
                            Description = "An old fort of Lahore",
                            Name = "Lahore Fort"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 3,
                            Description = "Fort of Rani Kot",
                            Name = "Rani Kot Fort"
                        });
                });

            modelBuilder.Entity("Entities.PlaceToVisit", b =>
                {
                    b.HasOne("Entities.City", "City")
                        .WithMany("PlacesToVisit")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
