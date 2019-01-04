﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Bookshelf.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<int?>("Length");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<double>("PurchasePrice");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Domain.Bookshelf.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<string>("PageNumber");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Quote");
                });

            modelBuilder.Entity("Domain.Inventory.Attributes.ItemColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.HasKey("Id");

                    b.ToTable("ItemColor");
                });

            modelBuilder.Entity("Domain.Inventory.Attributes.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("ItemType");
                });

            modelBuilder.Entity("Domain.Inventory.InventoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("ItemColorId");

                    b.Property<int>("ItemTypeId");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<double>("PurchasePrice");

                    b.Property<string>("SerialNumber");

                    b.HasKey("Id");

                    b.HasIndex("ItemColorId");

                    b.HasIndex("ItemTypeId");

                    b.ToTable("InventoryItem");
                });

            modelBuilder.Entity("Domain.Bookshelf.Quote", b =>
                {
                    b.HasOne("Domain.Bookshelf.Book", "Book")
                        .WithMany("Quotes")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Inventory.InventoryItem", b =>
                {
                    b.HasOne("Domain.Inventory.Attributes.ItemColor", "ItemColor")
                        .WithMany()
                        .HasForeignKey("ItemColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Inventory.Attributes.ItemType", "ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
