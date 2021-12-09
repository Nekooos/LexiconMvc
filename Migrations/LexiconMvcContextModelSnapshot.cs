﻿// <auto-generated />
using System;
using LexiconMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LexiconMvc.Migrations
{
    [DbContext(typeof(LexiconMvcContext))]
    partial class LexiconMvcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LexiconMvc.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "b51a0594-859b-40a1-830b-27d217a76f31",
                            ConcurrencyStamp = "61a893ab-850d-4924-a4dd-9ce4ac809593",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "6f421e74-2faf-4048-bdc8-4eaf1cbca939",
                            ConcurrencyStamp = "a6415699-dd48-4a22-b29e-e436641bf6e9",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("LexiconMvc.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("BirthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "c81479b4-bd7a-4d1f-9046-b954b29977ab",
                            AccessFailedCount = 0,
                            BirthDate = "1/1 1980",
                            ConcurrencyStamp = "5de4306f-e2f7-4033-9363-b3db0e3059d4",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminsson",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEAOYbfrkYWHF7t89F9zeYpGhJRTvgceSN9RfsvQDBH2DyzaokslIhhrVl4chttKwSg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "52b26317-717a-494e-abd1-ebeb7628c438",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        },
                        new
                        {
                            Id = "fa7a9b42-bea4-40ad-ab2a-0e7f851456ee",
                            AccessFailedCount = 0,
                            BirthDate = "1/1 1990",
                            ConcurrencyStamp = "2ae52e1c-efb8-4821-ba31-34d20d2b302c",
                            Email = "user@user.com",
                            EmailConfirmed = false,
                            FirstName = "User",
                            LastName = "Usersson",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@USER.COM",
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAEAACcQAAAAEIuqOZ9+P7xhVSMCXrBKgNVTuLE8lJ5E9K3W7U5nZiiXwPOGWuDK9OK2E5onnmHwEQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0ac9c109-7222-4251-9a71-166aa7e27c32",
                            TwoFactorEnabled = false,
                            UserName = "user@user.com"
                        });
                });

            modelBuilder.Entity("LexiconMvc.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CityId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 6,
                            CountryId = 11,
                            Name = "StockHolm"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 11,
                            Name = "Göteborg"
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 12,
                            Name = "Oslo"
                        });
                });

            modelBuilder.Entity("LexiconMvc.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CountryId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Name = "Sverige"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Norge"
                        });
                });

            modelBuilder.Entity("LexiconMvc.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Language");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Name = "Svenska"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Norska"
                        },
                        new
                        {
                            Id = 13,
                            Name = "English"
                        });
                });

            modelBuilder.Entity("LexiconMvc.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PersonId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 6,
                            Name = "Kristoffer",
                            PhoneNumber = "0731112233"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 7,
                            Name = "Sara",
                            PhoneNumber = "0731112233"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 8,
                            Name = "Björgen",
                            PhoneNumber = "0731112233"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 6,
                            Name = "Marcus",
                            PhoneNumber = "0731112233"
                        });
                });

            modelBuilder.Entity("LexiconMvc.Models.PersonLanguage", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.HasKey("PersonId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("PersonLanguage");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            LanguageId = 11
                        },
                        new
                        {
                            PersonId = 2,
                            LanguageId = 11
                        },
                        new
                        {
                            PersonId = 3,
                            LanguageId = 12
                        },
                        new
                        {
                            PersonId = 4,
                            LanguageId = 11
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<string>");
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

            modelBuilder.Entity("LexiconMvc.Models.ApplicationUserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<string>");

                    b.Property<string>("RoleId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("RoleId1");

                    b.HasIndex("UserId1");

                    b.HasDiscriminator().HasValue("ApplicationUserRole");
                });

            modelBuilder.Entity("LexiconMvc.Models.City", b =>
                {
                    b.HasOne("LexiconMvc.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("LexiconMvc.Models.Person", b =>
                {
                    b.HasOne("LexiconMvc.Models.City", "City")
                        .WithMany("Persons")
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("LexiconMvc.Models.PersonLanguage", b =>
                {
                    b.HasOne("LexiconMvc.Models.Language", "Language")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LexiconMvc.Models.Person", "Person")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("LexiconMvc.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LexiconMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LexiconMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("LexiconMvc.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LexiconMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LexiconMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LexiconMvc.Models.ApplicationUserRole", b =>
                {
                    b.HasOne("LexiconMvc.Models.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId1");

                    b.HasOne("LexiconMvc.Models.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId1");
                });
#pragma warning restore 612, 618
        }
    }
}
