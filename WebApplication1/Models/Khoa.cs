using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Khoa
    {
        [Key]
        [Required, MaxLength(20)]
        public string MaKhoa { get; set; }
        [Required, MaxLength(10)]
        public string TenKhoa { get; set; }
    }
}