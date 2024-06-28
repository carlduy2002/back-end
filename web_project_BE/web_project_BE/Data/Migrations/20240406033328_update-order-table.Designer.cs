﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using web_project_BE.Data;

#nullable disable

namespace webprojectBE.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240406033328_update-order-table")]
    partial class updateordertable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("web_project_BE.Models.Account", b =>
                {
                    b.Property<int>("account_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("account_id"));

                    b.Property<string>("account_address")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("account_avatar")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("account_birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("account_confirm_password")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("account_email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("account_gender")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("account_password")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("account_phone")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<int>("account_role_id")
                        .HasColumnType("int");

                    b.Property<int>("account_status")
                        .HasColumnType("int");

                    b.Property<string>("account_username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("refesh_token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("refesh_token_exprytime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("reset_password_exprytime")
                        .HasColumnType("datetime2");

                    b.Property<string>("reset_password_token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("token")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("account_id");

                    b.HasIndex("account_role_id");

                    b.ToTable("Accounts", (string)null);
                });

            modelBuilder.Entity("web_project_BE.Models.Cart", b =>
                {
                    b.Property<int>("cart_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cart_id"));

                    b.Property<int>("account_id")
                        .HasColumnType("int");

                    b.HasKey("cart_id");

                    b.HasIndex("account_id")
                        .IsUnique();

                    b.ToTable("Carts", (string)null);
                });

            modelBuilder.Entity("web_project_BE.Models.Cart_Detail", b =>
                {
                    b.Property<int>("cd_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cd_id"));

                    b.Property<int>("cd_cart_id")
                        .HasColumnType("int");

                    b.Property<int>("cd_product_id")
                        .HasColumnType("int");

                    b.Property<int>("cd_quantity")
                        .HasColumnType("int");

                    b.HasKey("cd_id");

                    b.HasIndex("cd_cart_id");

                    b.HasIndex("cd_product_id");

                    b.ToTable("Cart_Details", (string)null);
                });

            modelBuilder.Entity("web_project_BE.Models.Category", b =>
                {
                    b.Property<int>("category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("category_id"));

                    b.Property<string>("category_description")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("category_name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("category_status")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("category_id");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("web_project_BE.Models.Image", b =>
                {
                    b.Property<int>("image_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("image_id"));

                    b.Property<int>("i_product_id")
                        .HasColumnType("int");

                    b.Property<string>("image_uri")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("image_id");

                    b.HasIndex("i_product_id");

                    b.ToTable("Images", (string)null);
                });

            modelBuilder.Entity("web_project_BE.Models.Order", b =>
                {
                    b.Property<int>("order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("order_id"));

                    b.Property<DateTime?>("delivery_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("o_account_id")
                        .HasColumnType("int");

                    b.Property<string>("order_address")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("order_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("order_note")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("order_payment")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("order_phone")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<int>("order_quantity")
                        .HasColumnType("int");

                    b.Property<string>("order_status")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("order_id");

                    b.HasIndex("o_account_id");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("web_project_BE.Models.Order_Detail", b =>
                {
                    b.Property<int>("od_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("od_id"));

                    b.Property<int>("od_order_id")
                        .HasColumnType("int");

                    b.Property<int>("od_product_id")
                        .HasColumnType("int");

                    b.Property<int>("od_quantity")
                        .HasColumnType("int");

                    b.HasKey("od_id");

                    b.HasIndex("od_order_id");

                    b.HasIndex("od_product_id");

                    b.ToTable("Order_Details", (string)null);
                });

            modelBuilder.Entity("web_project_BE.Models.Product", b =>
                {
                    b.Property<int>("product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("product_id"));

                    b.Property<int>("p_category_id")
                        .HasColumnType("int");

                    b.Property<int>("p_size_id")
                        .HasColumnType("int");

                    b.Property<int>("p_supplier_id")
                        .HasColumnType("int");

                    b.Property<string>("product_description")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("product_image")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("product_import_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<double>("product_original_price")
                        .HasColumnType("float");

                    b.Property<int>("product_quantity_stock")
                        .HasColumnType("int");

                    b.Property<double>("product_sell_price")
                        .HasColumnType("float");

                    b.Property<string>("product_status")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("product_id");

                    b.HasIndex("p_category_id");

                    b.HasIndex("p_size_id");

                    b.HasIndex("p_supplier_id");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("web_project_BE.Models.Roles", b =>
                {
                    b.Property<int>("role_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("role_id"));

                    b.Property<string>("role_name")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("role_id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("web_project_BE.Models.Size", b =>
                {
                    b.Property<int>("size_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("size_id"));

                    b.Property<int>("size_number")
                        .HasColumnType("int");

                    b.HasKey("size_id");

                    b.ToTable("Sizes", (string)null);
                });

            modelBuilder.Entity("web_project_BE.Models.Supplier", b =>
                {
                    b.Property<int>("supplier_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("supplier_id"));

                    b.Property<string>("supplier_address")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("supplier_email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("supplier_name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("supplier_phone")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("supplier_status")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("supplier_id");

                    b.ToTable("Suppliers", (string)null);
                });

            modelBuilder.Entity("web_project_BE.Models.Account", b =>
                {
                    b.HasOne("web_project_BE.Models.Roles", "role")
                        .WithMany("accounts")
                        .HasForeignKey("account_role_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("role");
                });

            modelBuilder.Entity("web_project_BE.Models.Cart", b =>
                {
                    b.HasOne("web_project_BE.Models.Account", "Account")
                        .WithOne("Cart")
                        .HasForeignKey("web_project_BE.Models.Cart", "account_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("web_project_BE.Models.Cart_Detail", b =>
                {
                    b.HasOne("web_project_BE.Models.Cart", "cart")
                        .WithMany()
                        .HasForeignKey("cd_cart_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("web_project_BE.Models.Product", "product")
                        .WithMany("cart_detail")
                        .HasForeignKey("cd_product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cart");

                    b.Navigation("product");
                });

            modelBuilder.Entity("web_project_BE.Models.Image", b =>
                {
                    b.HasOne("web_project_BE.Models.Product", "product")
                        .WithMany("images")
                        .HasForeignKey("i_product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("web_project_BE.Models.Order", b =>
                {
                    b.HasOne("web_project_BE.Models.Account", "account")
                        .WithMany("orders")
                        .HasForeignKey("o_account_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");
                });

            modelBuilder.Entity("web_project_BE.Models.Order_Detail", b =>
                {
                    b.HasOne("web_project_BE.Models.Order", "order")
                        .WithMany()
                        .HasForeignKey("od_order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("web_project_BE.Models.Product", "product")
                        .WithMany("order_details")
                        .HasForeignKey("od_product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");

                    b.Navigation("product");
                });

            modelBuilder.Entity("web_project_BE.Models.Product", b =>
                {
                    b.HasOne("web_project_BE.Models.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("p_category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("web_project_BE.Models.Size", "size")
                        .WithMany("product")
                        .HasForeignKey("p_size_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("web_project_BE.Models.Supplier", "supplier")
                        .WithMany("products")
                        .HasForeignKey("p_supplier_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("size");

                    b.Navigation("supplier");
                });

            modelBuilder.Entity("web_project_BE.Models.Account", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("orders");
                });

            modelBuilder.Entity("web_project_BE.Models.Category", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("web_project_BE.Models.Product", b =>
                {
                    b.Navigation("cart_detail");

                    b.Navigation("images");

                    b.Navigation("order_details");
                });

            modelBuilder.Entity("web_project_BE.Models.Roles", b =>
                {
                    b.Navigation("accounts");
                });

            modelBuilder.Entity("web_project_BE.Models.Size", b =>
                {
                    b.Navigation("product");
                });

            modelBuilder.Entity("web_project_BE.Models.Supplier", b =>
                {
                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}
