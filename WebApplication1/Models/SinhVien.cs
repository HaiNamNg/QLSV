using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        [Required(ErrorMessage = "Ten sinh vien khong duoc de trong")]
        public string HoVaTen { get; set; }
        [Required]
        public string MaSinhVien { get; set; }
        [Required]
        public string GioiTinh { get; set; }
        [Required]
        public string DiaChi { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Sdt { get; set; }
    }
}