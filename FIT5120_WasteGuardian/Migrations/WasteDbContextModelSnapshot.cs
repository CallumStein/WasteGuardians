﻿// <auto-generated />
using System;
using FIT5120_WasteGuardian.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FIT5120_WasteGuardian.Migrations
{
    [DbContext(typeof(WasteDbContext))]
    partial class WasteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("FIT5120_WasteGuardian.Models.KerbsideService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Collected")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Contaminated")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Service")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Sorted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Year")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("KerbsideServices");
                });

            modelBuilder.Entity("FIT5120_WasteGuardian.Models.WasteCollected", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Collected")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sorted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Year")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WasteCollecteds");
                });
#pragma warning restore 612, 618
        }
    }
}