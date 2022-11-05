﻿// <auto-generated />
using APIWithUnitOfWork.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIWithUnitOfWork.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221105154427_AddChanges")]
    partial class AddChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("APIWithUnitOfWork.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "rhinoplasty"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dentist"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cardiologist"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Urology"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Oncology"
                        },
                        new
                        {
                            Id = 6,
                            Name = "exp-spine-surgery"
                        });
                });

            modelBuilder.Entity("APIWithUnitOfWork.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Turkey",
                            ShortName = "TR"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Iran",
                            ShortName = "IR"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Jamaica",
                            ShortName = "JM"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bahamas",
                            ShortName = "BS"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cayman Island",
                            ShortName = "CI"
                        });
                });

            modelBuilder.Entity("APIWithUnitOfWork.Data.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategortyId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategortyId");

                    b.HasIndex("CountryId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Address1",
                            CategortyId = 1,
                            CountryId = 1,
                            Name = "Mina",
                            Rating = 5.0,
                            Surname = "Amini"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Address1",
                            CategortyId = 1,
                            CountryId = 1,
                            Name = "Andi",
                            Rating = 4.4000000000000004,
                            Surname = "Naiak"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Address1",
                            CategortyId = 1,
                            CountryId = 1,
                            Name = "Sara",
                            Rating = 3.5,
                            Surname = "Doniat"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Address1",
                            CategortyId = 4,
                            CountryId = 2,
                            Name = "John",
                            Rating = 4.9000000000000004,
                            Surname = "Wilson"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Address1",
                            CategortyId = 5,
                            CountryId = 3,
                            Name = "Adams",
                            Rating = 3.7999999999999998,
                            Surname = "Robinson"
                        });
                });

            modelBuilder.Entity("APIWithUnitOfWork.Data.Doctor", b =>
                {
                    b.HasOne("APIWithUnitOfWork.Data.Category", "Category")
                        .WithMany("Doctors")
                        .HasForeignKey("CategortyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIWithUnitOfWork.Data.Country", "Country")
                        .WithMany("Doctors")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("APIWithUnitOfWork.Data.Category", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("APIWithUnitOfWork.Data.Country", b =>
                {
                    b.Navigation("Doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
