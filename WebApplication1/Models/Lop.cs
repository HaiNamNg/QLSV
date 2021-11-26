using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Lop
    {
        [Key]
        [Required, MaxLength(20)]
        public string TenLop { get; set; }
        [Required, MaxLength(20)]
        public string MaLop { get; set; }
        
        //public string MaKhoa { get; set; }
        //[ForeignKey("MaKhoa")]
        //public virtual Khoa Khoa { get; set; }
    }
}