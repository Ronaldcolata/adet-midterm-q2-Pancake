﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentRecordsApp.Models;

namespace StudentRecordsApp.Migrations
{
    [DbContext(typeof(AppIdentityDbContext))]
    partial class AppIdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "341743f0",
                            ConcurrencyStamp = "341743f0",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "02174cf0",
                            RoleId = "341743f0"
                        });
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("StudentRecordsApp.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)");

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

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(100)");

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

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "02174cf0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fea72734-9174-4db6-9ad2-fcc0c94692cc",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Raquel",
                            LastName = "Sorila",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEEXvj4HDNFuXn4B2w0suAsDOGEoaykEtqSVJa7xE3m6Kf2reoj3Q7FFc0JHW6A/rzQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2f37f786-0dbb-40e1-85f3-fa60613a6a2a",
                            TwoFactorEnabled = false,
                            UserID = "0",
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("StudentRecordsApp.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Final_Assign1")
                        .HasColumnType("int");

                    b.Property<int>("Final_Assign2")
                        .HasColumnType("int");

                    b.Property<int>("Final_Assign3")
                        .HasColumnType("int");

                    b.Property<int>("Final_Quiz1")
                        .HasColumnType("int");

                    b.Property<int>("Final_Quiz2")
                        .HasColumnType("int");

                    b.Property<int>("Final_Quiz3")
                        .HasColumnType("int");

                    b.Property<int>("Midterm_Assign1")
                        .HasColumnType("int");

                    b.Property<int>("Midterm_Assign2")
                        .HasColumnType("int");

                    b.Property<int>("Midterm_Assign3")
                        .HasColumnType("int");

                    b.Property<int>("Midterm_Quiz1")
                        .HasColumnType("int");

                    b.Property<int>("Midterm_Quiz2")
                        .HasColumnType("int");

                    b.Property<int>("Midterm_Quiz3")
                        .HasColumnType("int");

                    b.Property<int>("Prefinal_Assign1")
                        .HasColumnType("int");

                    b.Property<int>("Prefinal_Assign2")
                        .HasColumnType("int");

                    b.Property<int>("Prefinal_Assign3")
                        .HasColumnType("int");

                    b.Property<int>("Prefinal_Quiz1")
                        .HasColumnType("int");

                    b.Property<int>("Prefinal_Quiz2")
                        .HasColumnType("int");

                    b.Property<int>("Prefinal_Quiz3")
                        .HasColumnType("int");

                    b.Property<int>("Prelim_Assign1")
                        .HasColumnType("int");

                    b.Property<int>("Prelim_Assign2")
                        .HasColumnType("int");

                    b.Property<int>("Prelim_Assign3")
                        .HasColumnType("int");

                    b.Property<int>("Prelim_Quiz1")
                        .HasColumnType("int");

                    b.Property<int>("Prelim_Quiz2")
                        .HasColumnType("int");

                    b.Property<int>("Prelim_Quiz3")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentID");

                    b.ToTable("Grade");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Final_Assign1 = 6,
                            Final_Assign2 = 8,
                            Final_Assign3 = 8,
                            Final_Quiz1 = 7,
                            Final_Quiz2 = 7,
                            Final_Quiz3 = 7,
                            Midterm_Assign1 = 6,
                            Midterm_Assign2 = 5,
                            Midterm_Assign3 = 9,
                            Midterm_Quiz1 = 8,
                            Midterm_Quiz2 = 7,
                            Midterm_Quiz3 = 9,
                            Prefinal_Assign1 = 6,
                            Prefinal_Assign2 = 7,
                            Prefinal_Assign3 = 7,
                            Prefinal_Quiz1 = 5,
                            Prefinal_Quiz2 = 7,
                            Prefinal_Quiz3 = 9,
                            Prelim_Assign1 = 6,
                            Prelim_Assign2 = 7,
                            Prelim_Assign3 = 6,
                            Prelim_Quiz1 = 8,
                            Prelim_Quiz2 = 7,
                            Prelim_Quiz3 = 9,
                            StudentID = 1
                        },
                        new
                        {
                            Id = 2,
                            Final_Assign1 = 6,
                            Final_Assign2 = 8,
                            Final_Assign3 = 8,
                            Final_Quiz1 = 8,
                            Final_Quiz2 = 7,
                            Final_Quiz3 = 9,
                            Midterm_Assign1 = 6,
                            Midterm_Assign2 = 8,
                            Midterm_Assign3 = 8,
                            Midterm_Quiz1 = 8,
                            Midterm_Quiz2 = 5,
                            Midterm_Quiz3 = 9,
                            Prefinal_Assign1 = 6,
                            Prefinal_Assign2 = 7,
                            Prefinal_Assign3 = 7,
                            Prefinal_Quiz1 = 5,
                            Prefinal_Quiz2 = 7,
                            Prefinal_Quiz3 = 9,
                            Prelim_Assign1 = 6,
                            Prelim_Assign2 = 7,
                            Prelim_Assign3 = 5,
                            Prelim_Quiz1 = 7,
                            Prelim_Quiz2 = 7,
                            Prelim_Quiz3 = 9,
                            StudentID = 2
                        },
                        new
                        {
                            Id = 3,
                            Final_Assign1 = 6,
                            Final_Assign2 = 9,
                            Final_Assign3 = 8,
                            Final_Quiz1 = 5,
                            Final_Quiz2 = 7,
                            Final_Quiz3 = 7,
                            Midterm_Assign1 = 6,
                            Midterm_Assign2 = 8,
                            Midterm_Assign3 = 8,
                            Midterm_Quiz1 = 8,
                            Midterm_Quiz2 = 5,
                            Midterm_Quiz3 = 9,
                            Prefinal_Assign1 = 6,
                            Prefinal_Assign2 = 5,
                            Prefinal_Assign3 = 7,
                            Prefinal_Quiz1 = 5,
                            Prefinal_Quiz2 = 7,
                            Prefinal_Quiz3 = 9,
                            Prelim_Assign1 = 6,
                            Prelim_Assign2 = 7,
                            Prelim_Assign3 = 5,
                            Prelim_Quiz1 = 7,
                            Prelim_Quiz2 = 7,
                            Prelim_Quiz3 = 9,
                            StudentID = 3
                        });
                });

            modelBuilder.Entity("StudentRecordsApp.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cavite",
                            Email = "carson_alexander@email.com",
                            FirstName = "Carson",
                            LastName = "Alexander",
                            StudentId = "100001"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Cavite",
                            Email = "meredith_alonso@email.com",
                            FirstName = "Meredith",
                            LastName = "Alonso",
                            StudentId = "100002"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Cavite",
                            Email = "arturo_anand@email.com",
                            FirstName = "Arturo",
                            LastName = "Anand",
                            StudentId = "100003"
                        });
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
                    b.HasOne("StudentRecordsApp.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StudentRecordsApp.Models.AppUser", null)
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

                    b.HasOne("StudentRecordsApp.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StudentRecordsApp.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentRecordsApp.Models.Grade", b =>
                {
                    b.HasOne("StudentRecordsApp.Models.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentRecordsApp.Models.Student", b =>
                {
                    b.Navigation("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}
