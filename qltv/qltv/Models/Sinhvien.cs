﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace qltv.Models
{
    public partial class Sinhvien
    {
        public Sinhvien()
        {
            Muons = new HashSet<Muon>();
        }

        public int SinhvienId { get; set; }
        public string Masosinhvien { get; set; }
        public string Tensinhvien { get; set; }
        public string Diachi { get; set; }
        public string Lop { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Email { get; set; }
        public string Matkhau { get; set; }
        public string SoCmnd { get; set; }
        public string Khoa { get; set; }

        public virtual ICollection<Muon> Muons { get; set; }
    }
}