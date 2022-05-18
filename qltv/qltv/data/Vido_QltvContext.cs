﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using qltv.Models;

namespace qltv.Data
{
    public partial class Vido_QltvContext : DbContext
    {
        public Vido_QltvContext()
        {
        }

        public Vido_QltvContext(DbContextOptions<Vido_QltvContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booklist> Booklists { get; set; }
        public virtual DbSet<Muon> Muons { get; set; }
        public virtual DbSet<NhaXb> NhaXbs { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<Sinhvien> Sinhviens { get; set; }
        public virtual DbSet<Tacgia> Tacgia { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<Thuthu> Thuthus { get; set; }
        public virtual DbSet<Tra> Tras { get; set; }
        public virtual DbSet<Vitri> Vitris { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booklist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Booklist");

                entity.Property(e => e.NamXb).HasColumnName("NamXB");

                entity.Property(e => e.Soke)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Masach)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Tensach)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Tentacgia)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tentheloai).HasMaxLength(100);

                entity.Property(e => e.Tenxuatban)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Muon>(entity =>
            {
                entity.ToTable("Muon");

                entity.HasIndex(e => e.SinhvienId, "IFK_MuonSinhvienId");

                entity.HasIndex(e => e.ThuthuId, "IFK_MuonThuthuId");

                entity.Property(e => e.Masosinhvien)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Ngaymuon).HasColumnType("date");

                entity.HasOne(d => d.Sach)
                    .WithMany(p => p.Muons)
                    .HasForeignKey(d => d.SachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MuonSachId");

                entity.HasOne(d => d.Sinhvien)
                    .WithMany(p => p.Muons)
                    .HasForeignKey(d => d.SinhvienId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MuonSinhvienId");

                entity.HasOne(d => d.Thuthu)
                    .WithMany(p => p.Muons)
                    .HasForeignKey(d => d.ThuthuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MuonThuthuId");
            });

            modelBuilder.Entity<NhaXb>(entity =>
            {
                entity.ToTable("NhaXB");

                entity.HasIndex(e => e.ThongtinNguoiDaiDien, "UQ__NhaXB__4A7CEFED6C297B21")
                    .IsUnique();

                entity.HasIndex(e => e.Tenxuatban, "UQ__NhaXB__6D26B287BE5A06C4")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__NhaXB__A9D1053421FB169A")
                    .IsUnique();

                entity.Property(e => e.NhaXbid).HasColumnName("NhaXBId");

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(160);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Tenxuatban)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ThongtinNguoiDaiDien)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.ToTable("Sach");

                entity.HasIndex(e => e.NhaXbid, "IFK_SachNhaXBId");

                entity.HasIndex(e => e.TacgiaId, "IFK_SachTacgiaId");

                entity.HasIndex(e => e.TheloaiId, "IFK_SachTheloaiId");

                entity.HasIndex(e => e.VitriId, "IFK_SachVitriId");

                entity.HasIndex(e => e.Tensach, "UQ__Sach__52BC27F302EF1166")
                    .IsUnique();

                entity.HasIndex(e => e.Masach, "UQ__Sach__9F923C89BC59DD17")
                    .IsUnique();

                entity.Property(e => e.Masach)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.NamXb).HasColumnName("NamXB");

                entity.Property(e => e.NhaXbid).HasColumnName("NhaXBId");

                entity.Property(e => e.Tensach)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.NhaXb)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.NhaXbid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SachNhaXBId");

                entity.HasOne(d => d.Tacgia)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.TacgiaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SachTacgiaId");

                entity.HasOne(d => d.Theloai)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.TheloaiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SachTheloaiId");

                entity.HasOne(d => d.Vitri)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.VitriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SachVitriId");
            });

            modelBuilder.Entity<Sinhvien>(entity =>
            {
                entity.ToTable("Sinhvien");

                entity.HasIndex(e => e.SinhvienId, "UQ__Sinhvien__15971891CABC3A8D")
                    .IsUnique();

                entity.HasIndex(e => e.Masosinhvien, "UQ__Sinhvien__82F4FB14C23C71E5")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__Sinhvien__A9D10534112B01C1")
                    .IsUnique();

                entity.HasIndex(e => e.SoCmnd, "UQ__Sinhvien__F5EEA1C62AA8B782")
                    .IsUnique();

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(160);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Khoa).HasMaxLength(50);

                entity.Property(e => e.Lop)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Masosinhvien)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Matkhau)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Ngaysinh).HasColumnType("date");

                entity.Property(e => e.SoCmnd)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("SoCMND");

                entity.Property(e => e.Tensinhvien)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Tacgia>(entity =>
            {
                entity.HasKey(e => e.TacgiaId);

                entity.Property(e => e.Ngaysinh).HasColumnType("date");

                entity.Property(e => e.Tentacgia)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TheLoai>(entity =>
            {
                entity.ToTable("TheLoai");

                entity.HasIndex(e => e.TheloaiId, "UQ__TheLoai__F373B1D018AD62AA")
                    .IsUnique();

                entity.Property(e => e.Tentheloai).HasMaxLength(100);
            });

            modelBuilder.Entity<Thuthu>(entity =>
            {
                entity.ToTable("Thuthu");

                entity.HasIndex(e => e.Username, "UQ__Thuthu__536C85E4CD45C451")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__Thuthu__A9D10534D43DE986")
                    .IsUnique();

                entity.HasIndex(e => e.Sdt, "UQ__Thuthu__CA1930A5971A95BC")
                    .IsUnique();

                entity.Property(e => e.Diachi).HasMaxLength(160);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Hoten)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Matkhau)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Ngaysinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("SDT");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Tra>(entity =>
            {
                entity.ToTable("Tra");

                entity.HasIndex(e => e.MuonId, "IFK_TraMuonId");

                entity.HasIndex(e => e.ThuthuId, "IFK_TraThuthuId");

                entity.HasIndex(e => e.MuonId, "UQ__Tra__58A90E59A728E364")
                    .IsUnique();

                entity.Property(e => e.Ngaytra).HasColumnType("date");

                entity.HasOne(d => d.Muon)
                    .WithOne(p => p.Tra)
                    .HasForeignKey<Tra>(d => d.MuonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraMuonId");

                entity.HasOne(d => d.Thuthu)
                    .WithMany(p => p.Tras)
                    .HasForeignKey(d => d.ThuthuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraThuthuId");
            });

            modelBuilder.Entity<Vitri>(entity =>
            {
                entity.ToTable("Vitri");

                entity.Property(e => e.Soke)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Tenhang)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}