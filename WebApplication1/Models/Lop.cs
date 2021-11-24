using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Lop
    {
        [Key]
        [Required, MaxLength(20)]
        public string MaHocPhan { get; set; }
        [Required, MaxLength(20)]
        public string TenHocPhan { get; set; }
        [Required, MaxLength(20)]
        public string SoTinChi { get; set; }
    }
}