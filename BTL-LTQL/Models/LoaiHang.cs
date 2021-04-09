using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL.Models
{
    [Table("LoaiHangs")]
    public class LoaiHang
    {
        public LoaiHang()
        {
            MatHangs = new HashSet<MatHang>();
        }
        [Key]
        [StringLength(5)]
        public string MaLoai { get; set; }

        [StringLength(50)]
        public string TenLoai { get; set; }

        public virtual ICollection<MatHang> MatHangs { get; set; }
    }
}