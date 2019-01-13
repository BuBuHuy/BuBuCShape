using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QuanLyHocPhan.Entity
{
    [Table("GV_HP")]
    public class GV_HP
    {
        [Key]
        [Column(Order = 0)]
        public string MSGV { get; set; }

        [Key]
        [Column(Order = 1)]
        public string MSHP { get; set; }

        [ForeignKey("MSGV")]
        public virtual GiangVien GV { get; set; }
        [ForeignKey("MSHP")]
        public virtual HocPhan HP { get; set; }
    }
}
