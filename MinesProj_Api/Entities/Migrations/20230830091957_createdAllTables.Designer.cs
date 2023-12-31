﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Entities;
#nullable disable

namespace MinesApi.Migrations
{
    [DbContext(typeof(MinesDbContext))]
    [Migration("20230830091957_createdAllTables")]
    partial class createdAllTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MinesApi.Models.County", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceRefId");

                    b.ToTable("Counties");
                });

            modelBuilder.Entity("MinesApi.Models.Mine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<string>("ComputerCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountyRefId")
                        .HasColumnType("int");

                    b.Property<short>("Degree")
                        .HasColumnType("smallint");

                    b.Property<bool>("EmploymentCommitment")
                        .HasColumnType("bit");

                    b.Property<string>("GeoghraphicPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InvestmentAmount")
                        .HasColumnType("int");

                    b.Property<int>("MineTypeRefId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnershipTypeRefId")
                        .HasColumnType("int");

                    b.Property<int>("ProvinceRefId")
                        .HasColumnType("int");

                    b.Property<int>("StatusRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountyRefId");

                    b.HasIndex("MineTypeRefId");

                    b.HasIndex("OwnershipTypeRefId");

                    b.HasIndex("ProvinceRefId");

                    b.HasIndex("StatusRefId");

                    b.ToTable("Mines");
                });

            modelBuilder.Entity("MinesApi.Models.MineType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MineTypes");
                });

            modelBuilder.Entity("MinesApi.Models.OwnershipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OwnershipTypes");
                });

            modelBuilder.Entity("MinesApi.Models.PhoneNumType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PhoneNumTypes");
                });

            modelBuilder.Entity("MinesApi.Models.PhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("NumberId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MineRefId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("PhoneNumTypeRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MineRefId");

                    b.HasIndex("PhoneNumTypeRefId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("MinesApi.Models.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("MinesApi.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("MinesApi.Models.County", b =>
                {
                    b.HasOne("MinesApi.Models.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("MinesApi.Models.Mine", b =>
                {
                    b.HasOne("MinesApi.Models.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyRefId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MinesApi.Models.MineType", "MineType")
                        .WithMany()
                        .HasForeignKey("MineTypeRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MinesApi.Models.OwnershipType", "OwnershipType")
                        .WithMany()
                        .HasForeignKey("OwnershipTypeRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MinesApi.Models.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceRefId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MinesApi.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("County");

                    b.Navigation("MineType");

                    b.Navigation("OwnershipType");

                    b.Navigation("Province");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("MinesApi.Models.PhoneNumber", b =>
                {
                    b.HasOne("MinesApi.Models.Mine", "Mine")
                        .WithMany()
                        .HasForeignKey("MineRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MinesApi.Models.PhoneNumType", "PhoneNumType")
                        .WithMany()
                        .HasForeignKey("PhoneNumTypeRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mine");

                    b.Navigation("PhoneNumType");
                });
#pragma warning restore 612, 618
        }
    }
}
