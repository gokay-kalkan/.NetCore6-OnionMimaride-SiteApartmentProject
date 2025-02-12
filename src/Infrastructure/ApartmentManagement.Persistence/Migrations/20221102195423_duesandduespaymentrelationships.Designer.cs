﻿// <auto-generated />
using System;
using ApartmentManagement.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApartmentManagement.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221102195423_duesandduespaymentrelationships")]
    partial class duesandduespaymentrelationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.Circle", b =>
                {
                    b.Property<int>("CircleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CircleId"), 1L, 1);

                    b.Property<string>("CircleNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DeleteStatus")
                        .HasColumnType("bit");

                    b.Property<int>("LivingPeopleCount")
                        .HasColumnType("int");

                    b.Property<string>("TenantOwner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CircleId");

                    b.HasIndex("UserId");

                    b.ToTable("Circles");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.Debts", b =>
                {
                    b.Property<int>("DebtsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DebtsId"), 1L, 1);

                    b.Property<double>("DebtsAmount")
                        .HasColumnType("float");

                    b.Property<bool>("DeleteStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DebtsId");

                    b.HasIndex("UserId");

                    b.ToTable("Debts");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.Dues", b =>
                {
                    b.Property<int>("DuesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DuesId"), 1L, 1);

                    b.Property<int?>("CircleId")
                        .HasColumnType("int");

                    b.Property<bool>("DeleteStatus")
                        .HasColumnType("bit");

                    b.Property<double?>("DuesPrice")
                        .HasColumnType("float");

                    b.Property<string>("DuesType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PaidStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DuesId");

                    b.HasIndex("CircleId");

                    b.HasIndex("UserId");

                    b.ToTable("Dues");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.DuesPayment", b =>
                {
                    b.Property<int>("DuesPaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DuesPaymentId"), 1L, 1);

                    b.Property<string>("CardName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cvc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DeleteStatus")
                        .HasColumnType("bit");

                    b.Property<int>("DuesId")
                        .HasColumnType("int");

                    b.Property<string>("ExpirationMonth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpirationYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PaymentAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DuesPaymentId");

                    b.HasIndex("DuesId");

                    b.HasIndex("UserId");

                    b.ToTable("DuesPayments");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManagerId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManagerId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.Recommendations", b =>
                {
                    b.Property<int>("RecommendationsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecommendationsId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RecommendationsId");

                    b.HasIndex("UserId");

                    b.ToTable("Recommendations");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<bool>("DeleteStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.Circle", b =>
                {
                    b.HasOne("ApartmentManagement.Domain.Entities.User", "User")
                        .WithMany("Circles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.Debts", b =>
                {
                    b.HasOne("ApartmentManagement.Domain.Entities.User", "User")
                        .WithMany("Debts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.Dues", b =>
                {
                    b.HasOne("ApartmentManagement.Domain.Entities.Circle", "Circle")
                        .WithMany("Dues")
                        .HasForeignKey("CircleId");

                    b.HasOne("ApartmentManagement.Domain.Entities.User", "User")
                        .WithMany("Dues")
                        .HasForeignKey("UserId");

                    b.Navigation("Circle");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.DuesPayment", b =>
                {
                    b.HasOne("ApartmentManagement.Domain.Entities.Dues", "Dues")
                        .WithMany("DuesPayments")
                        .HasForeignKey("DuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApartmentManagement.Domain.Entities.User", "User")
                        .WithMany("DuesPayments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dues");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.Recommendations", b =>
                {
                    b.HasOne("ApartmentManagement.Domain.Entities.User", "User")
                        .WithMany("Recommendations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.Circle", b =>
                {
                    b.Navigation("Dues");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.Dues", b =>
                {
                    b.Navigation("DuesPayments");
                });

            modelBuilder.Entity("ApartmentManagement.Domain.Entities.User", b =>
                {
                    b.Navigation("Circles");

                    b.Navigation("Debts");

                    b.Navigation("Dues");

                    b.Navigation("DuesPayments");

                    b.Navigation("Recommendations");
                });
#pragma warning restore 612, 618
        }
    }
}
