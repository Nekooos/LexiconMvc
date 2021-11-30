﻿// <auto-generated />
using LexiconMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LexiconMvc.Migrations
{
    [DbContext(typeof(LexiconMvcContext))]
    [Migration("20211129204112_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LexiconMvc.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PersonId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Göteborg",
                            Name = "Kristoffer",
                            PhoneNumber = "0701112233"
                        },
                        new
                        {
                            Id = 2,
                            City = "Växjö",
                            Name = "Marvin",
                            PhoneNumber = "0701112244"
                        },
                        new
                        {
                            Id = 3,
                            City = "Växjö",
                            Name = "Malin",
                            PhoneNumber = "0701112255"
                        },
                        new
                        {
                            Id = 4,
                            City = "Göteborg",
                            Name = "Sara",
                            PhoneNumber = "0701112266"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
