using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class QuanLySVDBcontext : DbContext
    {
        public QuanLySVDBcontext() : base("QuanLySVDBcontext")
        {

        }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<HocPhan> HocPhans { get; set; }


    }
}
//DESKTOP-GIPHEE4\SQLEXPRESS