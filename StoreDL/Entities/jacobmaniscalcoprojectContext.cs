﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StoreDL.Entities
{
    public partial class jacobmaniscalcoprojectContext : DbContext
    {
        public jacobmaniscalcoprojectContext()
        {
        }

        public jacobmaniscalcoprojectContext(DbContextOptions<jacobmaniscalcoprojectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<StoreFront> StoreFronts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPhoneNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LineItem");

                entity.Property(e => e.LineItemProductId).HasColumnName("LineItem_ProductID");

                entity.Property(e => e.StoreFrontId).HasColumnName("StoreFrontID");

                entity.HasOne(d => d.LineItemProduct)
                    .WithMany()
                    .HasForeignKey(d => d.LineItemProductId)
                    .HasConstraintName("FK__LineItem__LineIt__59C55456");

                entity.HasOne(d => d.StoreFront)
                    .WithMany()
                    .HasForeignKey(d => d.StoreFrontId)
                    .HasConstraintName("FK__LineItem__StoreF__58D1301D");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderPrice).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__Customer__51300E55");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("OrderItem");

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderProductId).HasColumnName("Order_ProductID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderItem__Order__55009F39");

                entity.HasOne(d => d.OrderProduct)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderItem__Order__540C7B00");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<StoreFront>(entity =>
            {
                entity.ToTable("StoreFront");

                entity.Property(e => e.StoreFrontId).HasColumnName("StoreFrontID");

                entity.Property(e => e.StoreFrontAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFrontName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
