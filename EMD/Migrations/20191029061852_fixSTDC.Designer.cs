﻿// <auto-generated />
using System;
using EMD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMD.Migrations
{
    [DbContext(typeof(EMDDbContext))]
    [Migration("20191029061852_fixSTDC")]
    partial class fixSTDC
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMD.Data.Models.EMDTbl", b =>
                {
                    b.Property<int>("EMDTblId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaHoanCoc")
                        .HasColumnType("bit");

                    b.Property<string>("DienGiai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DongHoSo")
                        .HasColumnType("datetime2");

                    b.Property<string>("GhiChu")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("HangHK")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("HetHan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoanCoc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoaiBK")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LoaiTien")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("NgayDC")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayPhat")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiNhap")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Number")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("PNR")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SGTCode")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("SLVeDaXuat")
                        .HasColumnType("int");

                    b.Property<int>("SLVeDatCoc")
                        .HasColumnType("int");

                    b.Property<decimal>("STDatCoc1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SoCTPhat")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("TienPhat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TienXuatVe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tracking")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("TyGia")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EMDTblId");

                    b.ToTable("EMDs");
                });

            modelBuilder.Entity("EMD.Data.Models.SGTCodeModel", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("batdau")
                        .HasColumnType("datetime2");

                    b.Property<string>("diemtq")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ketthuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("sgtcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sokhach")
                        .HasColumnType("int");

                    b.Property<string>("tuyentq")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SGTCodeModels");
                });
#pragma warning restore 612, 618
        }
    }
}
