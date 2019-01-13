using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QuanLyDiemCodeFirst.Entity
{
    [Table("DeTai")]
    public class DeTai
    {
        [Key] [StringLength(10)]
        public string MaDeTai { get; set; }

        public string TenDeTai { get; set; }

        public bool TinhTrang { get; set; }

        public DateTime NgayNhanDeTai { get; set; }

        public string ChuNhiem { get; set; }

       
        public string MaCapDeTai { get; set; }
        [ForeignKey("MaCapDeTai")]
        public virtual CapDeTai maCapDeTai { get; set; }
    }
}
