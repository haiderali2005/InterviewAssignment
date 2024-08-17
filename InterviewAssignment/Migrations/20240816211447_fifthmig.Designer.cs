﻿// <auto-generated />
using InterviewAssignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InterviewAssignment.Migrations
{
    [DbContext(typeof(AssignmentDbContext))]
    [Migration("20240816211447_fifthmig")]
    partial class fifthmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InterviewAssignment.Models.Order", b =>
                {
                    b.Property<int>("Order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Order_id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Order_id");

                    b.ToTable("table_order");
                });

            modelBuilder.Entity("InterviewAssignment.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetail_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetail_id"), 1L, 1);

                    b.Property<string>("FruitName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order_id")
                        .HasColumnType("int");

                    b.HasKey("OrderDetail_id");

                    b.HasIndex("Order_id");

                    b.ToTable("table_orderdetail");
                });

            modelBuilder.Entity("InterviewAssignment.Models.OrderDetail", b =>
                {
                    b.HasOne("InterviewAssignment.Models.Order", "Order")
                        .WithMany("orderdetail")
                        .HasForeignKey("Order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("InterviewAssignment.Models.Order", b =>
                {
                    b.Navigation("orderdetail");
                });
#pragma warning restore 612, 618
        }
    }
}
