﻿// <auto-generated />
using System;
using Airbnb.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Airbnb.DAL.Migrations
{
    [DbContext(typeof(AircbnbContext))]
    [Migration("20230622094546_v02525")]
    partial class v02525
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Airbnb.DAl.Amenity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "https://example.com/icon1.png",
                            Name = "Amenity 1"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "https://example.com/icon2.png",
                            Name = "Amenity 2"
                        });
                });

            modelBuilder.Entity("Airbnb.DAl.Booking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<Guid?>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("UserId", "PropertyId", "CheckInDate")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL AND [PropertyId] IS NOT NULL");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d9e527de-3d4a-404b-9e75-1424d10e0640"),
                            BookingDate = new DateTime(2023, 6, 22, 9, 45, 45, 890, DateTimeKind.Utc).AddTicks(8170),
                            CheckInDate = new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Utc),
                            CheckOutDate = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            NumberOfGuests = 4,
                            PropertyId = new Guid("a0149e8e-81ae-4213-b847-35c910bc5ed5"),
                            TotalPrice = 500.0,
                            UserId = "c4152243-47ce-4a63-a48a-3396d27640ef"
                        },
                        new
                        {
                            Id = new Guid("ed19e856-c242-43fb-84be-c65db85545ee"),
                            BookingDate = new DateTime(2023, 6, 22, 9, 45, 45, 890, DateTimeKind.Utc).AddTicks(8178),
                            CheckInDate = new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc),
                            CheckOutDate = new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Utc),
                            NumberOfGuests = 2,
                            PropertyId = new Guid("7587ebde-9b3a-441b-9b52-44c8364ada20"),
                            TotalPrice = 300.0,
                            UserId = "8d279fcd-143e-4c6c-be8d-ff7860eb239f"
                        });
                });

            modelBuilder.Entity("Airbnb.DAl.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Category 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Category 2"
                        });
                });

            modelBuilder.Entity("Airbnb.DAl.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CounrtyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CounrtyId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "City 1",
                            CounrtyId = 1
                        },
                        new
                        {
                            Id = 2,
                            CityName = "City 2",
                            CounrtyId = 1
                        });
                });

            modelBuilder.Entity("Airbnb.DAl.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryName = "Country 1"
                        },
                        new
                        {
                            Id = 2,
                            CountryName = "Country 2"
                        });
                });

            modelBuilder.Entity("Airbnb.DAl.Property", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AvailabilityType")
                        .HasColumnType("bit");

                    b.Property<int>("BathroomCount")
                        .HasColumnType("int");

                    b.Property<int>("BedCount")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal?>("Latitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Longitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MaximumNumberOfGuests")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("NumberOfReview")
                        .HasColumnType("int");

                    b.Property<double>("OverALLReview")
                        .HasColumnType("float");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("float");

                    b.Property<int>("RoomCount")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("UserId");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a0149e8e-81ae-4213-b847-35c910bc5ed5"),
                            Address = "Address 1",
                            AvailabilityType = true,
                            BathroomCount = 2,
                            BedCount = 4,
                            CategoryId = 1,
                            CityId = 1,
                            Description = "Description 1",
                            Latitude = 78.90m,
                            Longitude = 123.456m,
                            MaximumNumberOfGuests = 6,
                            Name = "Property 1",
                            NumberOfReview = 0,
                            OverALLReview = 0.0,
                            PricePerNight = 100.0,
                            RoomCount = 3,
                            UserId = "c4152243-47ce-4a63-a48a-3396d27640ef"
                        },
                        new
                        {
                            Id = new Guid("7587ebde-9b3a-441b-9b52-44c8364ada20"),
                            Address = "Address 2",
                            AvailabilityType = true,
                            BathroomCount = 1,
                            BedCount = 2,
                            CategoryId = 2,
                            CityId = 2,
                            Description = "Description 2",
                            Latitude = 12.34m,
                            Longitude = 45.678m,
                            MaximumNumberOfGuests = 4,
                            Name = "Property 2",
                            NumberOfReview = 0,
                            OverALLReview = 0.0,
                            PricePerNight = 80.0,
                            RoomCount = 2,
                            UserId = "8d279fcd-143e-4c6c-be8d-ff7860eb239f"
                        });
                });

            modelBuilder.Entity("Airbnb.DAl.PropertyAmenity", b =>
                {
                    b.Property<Guid>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AmenityId")
                        .HasColumnType("int");

                    b.HasKey("PropertyId", "AmenityId");

                    b.HasIndex("AmenityId");

                    b.ToTable("PropertyAmenities");

                    b.HasData(
                        new
                        {
                            PropertyId = new Guid("a0149e8e-81ae-4213-b847-35c910bc5ed5"),
                            AmenityId = 1
                        },
                        new
                        {
                            PropertyId = new Guid("7587ebde-9b3a-441b-9b52-44c8364ada20"),
                            AmenityId = 2
                        });
                });

            modelBuilder.Entity("Airbnb.DAl.PropertyImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("UserId");

                    b.ToTable("PropertyImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 6, 22, 12, 45, 45, 890, DateTimeKind.Local).AddTicks(8290),
                            Image = "image1.jpg",
                            PropertyId = new Guid("a0149e8e-81ae-4213-b847-35c910bc5ed5"),
                            UserId = "c4152243-47ce-4a63-a48a-3396d27640ef"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 6, 22, 12, 45, 45, 890, DateTimeKind.Local).AddTicks(8353),
                            Image = "image2.jpg",
                            PropertyId = new Guid("a0149e8e-81ae-4213-b847-35c910bc5ed5"),
                            UserId = "8d279fcd-143e-4c6c-be8d-ff7860eb239f"
                        });
                });

            modelBuilder.Entity("Airbnb.DAl.PropertyRule", b =>
                {
                    b.Property<Guid>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RuleId")
                        .HasColumnType("int");

                    b.HasKey("PropertyId", "RuleId");

                    b.HasIndex("RuleId");

                    b.ToTable("PropertyRules");

                    b.HasData(
                        new
                        {
                            PropertyId = new Guid("a0149e8e-81ae-4213-b847-35c910bc5ed5"),
                            RuleId = 1
                        },
                        new
                        {
                            PropertyId = new Guid("7587ebde-9b3a-441b-9b52-44c8364ada20"),
                            RuleId = 2
                        });
                });

            modelBuilder.Entity("Airbnb.DAl.Review", b =>
                {
                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("BookingId", "PropertyId", "UserId");

                    b.HasIndex("PropertyId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            BookingId = new Guid("d9e527de-3d4a-404b-9e75-1424d10e0640"),
                            PropertyId = new Guid("a0149e8e-81ae-4213-b847-35c910bc5ed5"),
                            UserId = "c4152243-47ce-4a63-a48a-3396d27640ef",
                            Comment = "This property was great!",
                            CreatedDate = new DateTime(2023, 6, 22, 9, 45, 45, 890, DateTimeKind.Utc).AddTicks(8187),
                            Rate = 4
                        },
                        new
                        {
                            BookingId = new Guid("ed19e856-c242-43fb-84be-c65db85545ee"),
                            PropertyId = new Guid("7587ebde-9b3a-441b-9b52-44c8364ada20"),
                            UserId = "8d279fcd-143e-4c6c-be8d-ff7860eb239f",
                            Comment = "Highly recommended!",
                            CreatedDate = new DateTime(2023, 6, 22, 9, 45, 45, 890, DateTimeKind.Utc).AddTicks(8268),
                            Rate = 5
                        });
                });

            modelBuilder.Entity("Airbnb.DAl.Rule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RuleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Rules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RuleName = "Rule 1"
                        },
                        new
                        {
                            Id = 2,
                            RuleName = "Rule 2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Airbnb.DAl.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LasttName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "c4152243-47ce-4a63-a48a-3396d27640ef",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4b4746ce-1f76-4370-9561-cb6ba9122b77",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1a687dca-c3a9-47e8-af99-546ba4fcbd6f",
                            TwoFactorEnabled = false,
                            UserName = "john@example.com",
                            About = "I am a regular user.",
                            FirstName = "John",
                            LasttName = "Doe",
                            UserType = 1
                        },
                        new
                        {
                            Id = "8d279fcd-143e-4c6c-be8d-ff7860eb239f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "52bd572a-9e2c-4b7f-92e7-dc4e7d9ffa22",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5aab5138-69d2-4e8d-b2c5-dba788b4f312",
                            TwoFactorEnabled = false,
                            UserName = "jane@example.com",
                            About = "I am an admin user.",
                            FirstName = "Jane",
                            LasttName = "Smith",
                            UserType = 0
                        });
                });

            modelBuilder.Entity("Airbnb.DAl.Booking", b =>
                {
                    b.HasOne("Airbnb.DAl.Property", "Property")
                        .WithMany("PropertyBookings")
                        .HasForeignKey("PropertyId");

                    b.HasOne("Airbnb.DAl.User", "User")
                        .WithMany("UserBookings")
                        .HasForeignKey("UserId");

                    b.Navigation("Property");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Airbnb.DAl.City", b =>
                {
                    b.HasOne("Airbnb.DAl.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CounrtyId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Airbnb.DAl.Property", b =>
                {
                    b.HasOne("Airbnb.DAl.Category", "Category")
                        .WithMany("CategoryProperties")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Airbnb.DAl.City", "City")
                        .WithMany("CityProperties")
                        .HasForeignKey("CityId");

                    b.HasOne("Airbnb.DAl.User", "User")
                        .WithMany("UserProperties")
                        .HasForeignKey("UserId");

                    b.Navigation("Category");

                    b.Navigation("City");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Airbnb.DAl.PropertyAmenity", b =>
                {
                    b.HasOne("Airbnb.DAl.Amenity", "Amenity")
                        .WithMany("AmenitiesProperty")
                        .HasForeignKey("AmenityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.DAl.Property", "Property")
                        .WithMany("PropertyAmenities")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amenity");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Airbnb.DAl.PropertyImage", b =>
                {
                    b.HasOne("Airbnb.DAl.Property", "Property")
                        .WithMany("PropertyImages")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.DAl.User", "User")
                        .WithMany("UserPropertyImages")
                        .HasForeignKey("UserId");

                    b.Navigation("Property");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Airbnb.DAl.PropertyRule", b =>
                {
                    b.HasOne("Airbnb.DAl.Property", "Property")
                        .WithMany("PropertyRules")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.DAl.Rule", "Rule")
                        .WithMany("RuleProperty")
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("Rule");
                });

            modelBuilder.Entity("Airbnb.DAl.Review", b =>
                {
                    b.HasOne("Airbnb.DAl.Booking", "Booking")
                        .WithMany("Reviews")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.DAl.Property", "Property")
                        .WithMany("Reviews")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.DAl.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Property");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airbnb.DAl.User", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithOne()
                        .HasForeignKey("Airbnb.DAl.User", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airbnb.DAl.Amenity", b =>
                {
                    b.Navigation("AmenitiesProperty");
                });

            modelBuilder.Entity("Airbnb.DAl.Booking", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Airbnb.DAl.Category", b =>
                {
                    b.Navigation("CategoryProperties");
                });

            modelBuilder.Entity("Airbnb.DAl.City", b =>
                {
                    b.Navigation("CityProperties");
                });

            modelBuilder.Entity("Airbnb.DAl.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Airbnb.DAl.Property", b =>
                {
                    b.Navigation("PropertyAmenities");

                    b.Navigation("PropertyBookings");

                    b.Navigation("PropertyImages");

                    b.Navigation("PropertyRules");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Airbnb.DAl.Rule", b =>
                {
                    b.Navigation("RuleProperty");
                });

            modelBuilder.Entity("Airbnb.DAl.User", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("UserBookings");

                    b.Navigation("UserProperties");

                    b.Navigation("UserPropertyImages");
                });
#pragma warning restore 612, 618
        }
    }
}
