﻿// <auto-generated />
using System;
using BiletAll.Entity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BiletAll.Entity.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220821001620_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BiletAll.Entity.Models.Firma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirmaAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirmaNo")
                        .HasColumnType("int");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Firmalar");
                });

            modelBuilder.Entity("BiletAll.Entity.Models.Pnr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("IslemTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("PnrNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeferId");

                    b.ToTable("Pnrlar");
                });

            modelBuilder.Entity("BiletAll.Entity.Models.PnrYolcu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Durum")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("KoltukNo")
                        .HasColumnType("int");

                    b.Property<int>("PnrId")
                        .HasColumnType("int");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YolcuId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PnrId");

                    b.HasIndex("YolcuId");

                    b.ToTable("PnrYolcular");
                });

            modelBuilder.Entity("BiletAll.Entity.Models.Sefer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FirmaId")
                        .HasColumnType("int");

                    b.Property<string>("KalkisNokta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KalkisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Peron")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SeferTipi")
                        .HasColumnType("int");

                    b.Property<string>("VarisNokta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VarisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("YaklasikVarisSuresi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FirmaId");

                    b.ToTable("Seferler");
                });

            modelBuilder.Entity("BiletAll.Entity.Models.Yolcu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Yolcular");
                });

            modelBuilder.Entity("BiletAll.Entity.Models.Pnr", b =>
                {
                    b.HasOne("BiletAll.Entity.Models.Sefer", "Sefer")
                        .WithMany("Pnrlar")
                        .HasForeignKey("SeferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sefer");
                });

            modelBuilder.Entity("BiletAll.Entity.Models.PnrYolcu", b =>
                {
                    b.HasOne("BiletAll.Entity.Models.Pnr", "Pnr")
                        .WithMany()
                        .HasForeignKey("PnrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BiletAll.Entity.Models.Yolcu", "Yolcu")
                        .WithMany()
                        .HasForeignKey("YolcuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pnr");

                    b.Navigation("Yolcu");
                });

            modelBuilder.Entity("BiletAll.Entity.Models.Sefer", b =>
                {
                    b.HasOne("BiletAll.Entity.Models.Firma", "Firma")
                        .WithMany("Seferler")
                        .HasForeignKey("FirmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firma");
                });

            modelBuilder.Entity("BiletAll.Entity.Models.Firma", b =>
                {
                    b.Navigation("Seferler");
                });

            modelBuilder.Entity("BiletAll.Entity.Models.Sefer", b =>
                {
                    b.Navigation("Pnrlar");
                });
#pragma warning restore 612, 618
        }
    }
}
