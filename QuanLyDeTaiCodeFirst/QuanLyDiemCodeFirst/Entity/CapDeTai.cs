using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QuanLyDiemCodeFirst.Entity
{
    [Table("CapDeTai")]
    public class CapDeTai
    {
        [Key]
        [StringLength(10)]
        public string MaCapDeTai { get; set; }

        public string TenCapDeTai { get; set; }

        public virtual ICollection<DeTai> listDeTai { get; set; }
    }
}
