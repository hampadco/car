﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastrcture.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240713182724_rrr")]
    partial class rrr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CatName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DeviceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("state")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("blokSilandr")
                        .HasColumnType("int");

                    b.Property<int>("bolboring")
                        .HasColumnType("int");

                    b.Property<int>("boshSilandr")
                        .HasColumnType("int");

                    b.Property<int>("carId")
                        .HasColumnType("int");

                    b.Property<int>("carbirator")
                        .HasColumnType("int");

                    b.Property<int>("charkhDande")
                        .HasColumnType("int");

                    b.Property<int>("compersorColer")
                        .HasColumnType("int");

                    b.Property<int>("fanar")
                        .HasColumnType("int");

                    b.Property<int>("fanarSopap")
                        .HasColumnType("int");

                    b.Property<int>("flayol")
                        .HasColumnType("int");

                    b.Property<int>("gearboxAuto")
                        .HasColumnType("int");

                    b.Property<int>("gearboxManual")
                        .HasColumnType("int");

                    b.Property<int>("headers")
                        .HasColumnType("int");

                    b.Property<int>("hozing")
                        .HasColumnType("int");

                    b.Property<int>("hydrolic")
                        .HasColumnType("int");

                    b.Property<int>("jabeFarman")
                        .HasColumnType("int");

                    b.Property<int>("karter")
                        .HasColumnType("int");

                    b.Property<int>("kaseCharkh")
                        .HasColumnType("int");

                    b.Property<int>("keshoie")
                        .HasColumnType("int");

                    b.Property<int>("komakfanar")
                        .HasColumnType("int");

                    b.Property<int>("manifold")
                        .HasColumnType("int");

                    b.Property<int>("milGarden")
                        .HasColumnType("int");

                    b.Property<int>("milMahak")
                        .HasColumnType("int");

                    b.Property<int>("milSopap")
                        .HasColumnType("int");

                    b.Property<int>("millang")
                        .HasColumnType("int");

                    b.Property<int>("motorKamel")
                        .HasColumnType("int");

                    b.Property<int>("motorStart")
                        .HasColumnType("int");

                    b.Property<int>("pichKarter")
                        .HasColumnType("int");

                    b.Property<int>("piston")
                        .HasColumnType("int");

                    b.Property<int>("plasticMotor")
                        .HasColumnType("int");

                    b.Property<int>("pumproghan")
                        .HasColumnType("int");

                    b.Property<int>("radiator")
                        .HasColumnType("int");

                    b.Property<int>("ring")
                        .HasColumnType("int");

                    b.Property<int>("ringPiston")
                        .HasColumnType("int");

                    b.Property<int>("safeCluch")
                        .HasColumnType("int");

                    b.Property<int>("sagDast")
                        .HasColumnType("int");

                    b.Property<int>("sarSilandr")
                        .HasColumnType("int");

                    b.Property<int>("sayerMotor")
                        .HasColumnType("int");

                    b.Property<int>("sayerZir")
                        .HasColumnType("int");

                    b.Property<int>("shafetKharoji")
                        .HasColumnType("int");

                    b.Property<int>("shafetVorodi")
                        .HasColumnType("int");

                    b.Property<int>("shaton")
                        .HasColumnType("int");

                    b.Property<int>("silandr")
                        .HasColumnType("int");

                    b.Property<int>("sopap")
                        .HasColumnType("int");

                    b.Property<int>("sopapPVC")
                        .HasColumnType("int");

                    b.Property<int>("superCharger")
                        .HasColumnType("int");

                    b.Property<int>("turboCharger")
                        .HasColumnType("int");

                    b.Property<int>("waterPump")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstAndLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Walet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("babat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("bardasht")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("resivername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resiverphone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sendername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senderphone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("variz")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("walets");
                });
#pragma warning restore 612, 618
        }
    }
}