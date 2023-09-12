﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.API.Context;

#nullable disable

namespace Store.API.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Store.API.Data.Entities.Category", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned")
                        .HasColumnName("PK_CAT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ST_CAT_NAME");

                    b.HasKey("Id");

                    b.ToTable("tb_category");
                });

            modelBuilder.Entity("Store.API.Data.Entities.Product", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned")
                        .HasColumnName("PK_PRO");

                    b.Property<uint>("CategoryId")
                        .HasColumnType("int unsigned")
                        .HasColumnName("FK_CAT_PRO");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DT_PRO_CREATED_AT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)")
                        .HasColumnName("ST_PRO_NAME");

                    b.Property<double>("PurchasePrice")
                        .HasColumnType("double")
                        .HasColumnName("DB_PRO_PURCHASE_PRICE");

                    b.Property<double>("SalePrice")
                        .HasColumnType("double")
                        .HasColumnName("DB_PRO_SALE_PRICE");

                    b.Property<int>("Storage")
                        .HasColumnType("int")
                        .HasColumnName("IN_PRO_STORAGE");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DT_PRO_UPDATED_AT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("tb_product");
                });

            modelBuilder.Entity("Store.API.Data.Entities.SellItem", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned")
                        .HasColumnName("PK_SELI");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("DB_SELI_PRICE");

                    b.Property<uint>("ProductId")
                        .HasColumnType("int unsigned")
                        .HasColumnName("FK_PRO_SELI");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("IN_SELI_QUANTITY");

                    b.Property<uint>("SellingId")
                        .HasColumnType("int unsigned")
                        .HasColumnName("FK_SEL_SELI");

                    b.HasKey("Id");

                    b.HasIndex("SellingId");

                    b.ToTable("tb_sell_item");
                });

            modelBuilder.Entity("Store.API.Data.Entities.Selling", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned")
                        .HasColumnName("PK_SEL");

                    b.Property<DateTime>("EndAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DT_SEL_END_AT");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("DB_SEL_PRICE");

                    b.Property<DateTime>("StartAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DT_SEL_START_AT");

                    b.HasKey("Id");

                    b.ToTable("tb_selling");
                });

            modelBuilder.Entity("Store.API.Data.Entities.Product", b =>
                {
                    b.HasOne("Store.API.Data.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Store.API.Data.Entities.SellItem", b =>
                {
                    b.HasOne("Store.API.Data.Entities.Selling", "Selling")
                        .WithMany("Items")
                        .HasForeignKey("SellingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Selling");
                });

            modelBuilder.Entity("Store.API.Data.Entities.Selling", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
