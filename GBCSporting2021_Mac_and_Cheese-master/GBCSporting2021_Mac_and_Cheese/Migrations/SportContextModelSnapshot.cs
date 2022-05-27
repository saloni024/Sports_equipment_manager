﻿// <auto-generated />
using System;
using GBCSporting2021_Mac_and_Cheese.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GBCSporting2021_Mac_and_Cheese.Migrations
{
    [DbContext(typeof(SportContext))]
    partial class SportContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GBCSporting2021_Mac_and_Cheese.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "Canada"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "USA"
                        },
                        new
                        {
                            CountryId = 3,
                            CountryName = "India"
                        },
                        new
                        {
                            CountryId = 4,
                            CountryName = "Australia"
                        });
                });

            modelBuilder.Entity("GBCSporting2021_Mac_and_Cheese.Models.Customer", b =>
                {
                    b.Property<int>("CustId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("CustEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustLName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustId");

                    b.HasIndex("CountryId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustId = 1,
                            Address = "123 Queen Street",
                            City = "Toronto",
                            CountryId = 1,
                            CustEmail = "kanthoni@pge.com",
                            CustFName = "Kaitlyn",
                            CustLName = "Anthoni",
                            CustPhone = "647-123-4567",
                            PostalCode = "M8N 6V5",
                            State = "Ontario"
                        },
                        new
                        {
                            CustId = 2,
                            Address = "27 Ganesh st.",
                            City = "Mumbai",
                            CountryId = 3,
                            CustEmail = "ania@mma.nidc.com",
                            CustFName = "Ania",
                            CustLName = "Irvin",
                            CustPhone = "998-765-1432",
                            PostalCode = "675 453",
                            State = "Maharashtra"
                        },
                        new
                        {
                            CustId = 3,
                            Address = "20 Central Perk",
                            City = "New York",
                            CountryId = 2,
                            CustEmail = "gonton@rft.com",
                            CustFName = "Gonzalo",
                            CustLName = "Keeton",
                            CustPhone = "256-432-5674",
                            PostalCode = "Y6R 4T8",
                            State = "New York"
                        },
                        new
                        {
                            CustId = 4,
                            Address = "445 West Village",
                            City = "Sydney",
                            CountryId = 4,
                            CustEmail = "jeffmalone@psl.com",
                            CustFName = "Jeffery",
                            CustLName = "Malone",
                            CustPhone = "343-089-0076",
                            PostalCode = "432 678",
                            State = "Sydney"
                        });
                });

            modelBuilder.Entity("GBCSporting2021_Mac_and_Cheese.Models.Incident", b =>
                {
                    b.Property<int>("IncidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOpened")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("TechnicianId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IncidentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TechnicianId");

                    b.ToTable("Incidents");

                    b.HasData(
                        new
                        {
                            IncidentId = 1,
                            CustomerId = 2,
                            DateClosed = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOpened = new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Could npt install the Draft Manager 1.0",
                            ProductId = 4,
                            TechnicianId = 1,
                            Title = "Could not install"
                        },
                        new
                        {
                            IncidentId = 2,
                            CustomerId = 1,
                            DateClosed = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOpened = new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Could npt install the Team Manager 1.0",
                            ProductId = 5,
                            Title = "Could not install"
                        });
                });

            modelBuilder.Entity("GBCSporting2021_Mac_and_Cheese.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateReleased")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Code = "TRNY10",
                            DateReleased = new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 4.9900000000000002,
                            ProductName = "Tournament Master 1.0"
                        },
                        new
                        {
                            ProductId = 2,
                            Code = "LEAG10",
                            DateReleased = new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 4.9900000000000002,
                            ProductName = "League Scheduler 1.0"
                        },
                        new
                        {
                            ProductId = 3,
                            Code = "LEAGD10",
                            DateReleased = new DateTime(2016, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 7.9900000000000002,
                            ProductName = "League Scheduler Deluxe 1.0"
                        },
                        new
                        {
                            ProductId = 4,
                            Code = "DRAFT10",
                            DateReleased = new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 4.9900000000000002,
                            ProductName = "Draft Manager 1.0"
                        },
                        new
                        {
                            ProductId = 5,
                            Code = "TEAM10",
                            DateReleased = new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 4.9900000000000002,
                            ProductName = "Team Manager 1.0"
                        });
                });

            modelBuilder.Entity("GBCSporting2021_Mac_and_Cheese.Models.Technician", b =>
                {
                    b.Property<int>("TechId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TechEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TechId");

                    b.ToTable("Technicians");

                    b.HasData(
                        new
                        {
                            TechId = 1,
                            TechEmail = "alison@sportsprosoftware.com",
                            TechName = "Alison Diaz",
                            TechPhone = "800-555-0443"
                        },
                        new
                        {
                            TechId = 2,
                            TechEmail = "awilson@sportsprosoftware.com",
                            TechName = "Andrew Wilson",
                            TechPhone = "800-555-0449"
                        },
                        new
                        {
                            TechId = 3,
                            TechEmail = "gfiori@sportsprosoftware.com",
                            TechName = "Gina Fiori",
                            TechPhone = "800-555-0459"
                        },
                        new
                        {
                            TechId = 4,
                            TechEmail = "jason@sportsprosoftware.com",
                            TechName = "Jason Lee",
                            TechPhone = "800-555-0444"
                        });
                });

            modelBuilder.Entity("GBCSporting2021_Mac_and_Cheese.Models.Customer", b =>
                {
                    b.HasOne("GBCSporting2021_Mac_and_Cheese.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("GBCSporting2021_Mac_and_Cheese.Models.Incident", b =>
                {
                    b.HasOne("GBCSporting2021_Mac_and_Cheese.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GBCSporting2021_Mac_and_Cheese.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GBCSporting2021_Mac_and_Cheese.Models.Technician", "Technician")
                        .WithMany()
                        .HasForeignKey("TechnicianId");

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Technician");
                });
#pragma warning restore 612, 618
        }
    }
}
