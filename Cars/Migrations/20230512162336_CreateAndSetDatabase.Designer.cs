﻿// <auto-generated />
using System;
using Cars.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cars.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230512162336_CreateAndSetDatabase")]
    partial class CreateAndSetDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cars.Models.BodyType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehiclesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("VehiclesID");

                    b.ToTable("BodyTypes");
                });

            modelBuilder.Entity("Cars.Models.Colors", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Cars.Models.Fuels", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Fuel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehiclesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("VehiclesID");

                    b.ToTable("Fuels");
                });

            modelBuilder.Entity("Cars.Models.Images", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("bit");

                    b.Property<int>("VehiclesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("VehiclesID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Cars.Models.Tags", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Cars.Models.VehicleColors", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ColorsID")
                        .HasColumnType("int");

                    b.Property<int>("VehiclesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ColorsID");

                    b.HasIndex("VehiclesID");

                    b.ToTable("VehicleColors");
                });

            modelBuilder.Entity("Cars.Models.VehicleTags", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("ColorsID")
                        .HasColumnType("int");

                    b.Property<int>("TagsID")
                        .HasColumnType("int");

                    b.Property<int>("VehiclesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ColorsID");

                    b.HasIndex("TagsID");

                    b.HasIndex("VehiclesID");

                    b.ToTable("VehicleTags");
                });

            modelBuilder.Entity("Cars.Models.Vehicles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Engine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProducedYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Cars.Models.BodyType", b =>
                {
                    b.HasOne("Cars.Models.Vehicles", "Vehicles")
                        .WithMany("BodyTypes")
                        .HasForeignKey("VehiclesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Cars.Models.Fuels", b =>
                {
                    b.HasOne("Cars.Models.Vehicles", "Vehicles")
                        .WithMany("Fuels")
                        .HasForeignKey("VehiclesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Cars.Models.Images", b =>
                {
                    b.HasOne("Cars.Models.Vehicles", "Vehicles")
                        .WithMany("Images")
                        .HasForeignKey("VehiclesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Cars.Models.VehicleColors", b =>
                {
                    b.HasOne("Cars.Models.Colors", "Colors")
                        .WithMany()
                        .HasForeignKey("ColorsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cars.Models.Vehicles", "Vehicles")
                        .WithMany()
                        .HasForeignKey("VehiclesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colors");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Cars.Models.VehicleTags", b =>
                {
                    b.HasOne("Cars.Models.Colors", null)
                        .WithMany("VehicleTags")
                        .HasForeignKey("ColorsID");

                    b.HasOne("Cars.Models.Tags", "Tags")
                        .WithMany("VehicleTags")
                        .HasForeignKey("TagsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cars.Models.Vehicles", "Vehicles")
                        .WithMany("VehicleTags")
                        .HasForeignKey("VehiclesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tags");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Cars.Models.Colors", b =>
                {
                    b.Navigation("VehicleTags");
                });

            modelBuilder.Entity("Cars.Models.Tags", b =>
                {
                    b.Navigation("VehicleTags");
                });

            modelBuilder.Entity("Cars.Models.Vehicles", b =>
                {
                    b.Navigation("BodyTypes");

                    b.Navigation("Fuels");

                    b.Navigation("Images");

                    b.Navigation("VehicleTags");
                });
#pragma warning restore 612, 618
        }
    }
}
