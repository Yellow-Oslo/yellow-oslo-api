﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yellow.Oslo.Data;

#nullable disable

namespace Yellow.Oslo.Api.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Yellow.Oslo.Domain.Catalog.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Nike",
                            Description = "Ohio State shirt",
                            Name = "Shirt",
                            Price = 29.99m
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Nike",
                            Description = "Ohio State shorts",
                            Name = "Shorts",
                            Price = 44.99m
                        });
                });

            modelBuilder.Entity("Yellow.Oslo.Domain.Catalog.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Star")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Stars")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("Yellow.Oslo.Domain.Catalog.Rating", b =>
                {
                    b.HasOne("Yellow.Oslo.Domain.Catalog.Item", null)
                        .WithMany("Ratings")
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("Yellow.Oslo.Domain.Catalog.Item", b =>
                {
                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
