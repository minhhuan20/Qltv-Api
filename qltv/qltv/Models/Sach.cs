﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace qltv.Models
{
    public partial class Sach
    {
        public Sach()
        {
            Muons = new HashSet<Muon>();
        }

        public int SachId { get; set; }
        public string Masach { get; set; }
        public string Tensach { get; set; }
        public int TacgiaId { get; set; }
        public int TheloaiId { get; set; }
        public int NhaXbid { get; set; }
        public int NamXb { get; set; }
        public int Soban { get; set; }
        public int VitriId { get; set; }
        public byte[] Img { get; set; }

        public virtual NhaXb NhaXb { get; set; }
        public virtual Tacgia Tacgia { get; set; }
        public virtual TheLoai Theloai { get; set; }
        public virtual Vitri Vitri { get; set; }
        public virtual ICollection<Muon> Muons { get; set; }
    }
}