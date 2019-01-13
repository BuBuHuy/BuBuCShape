using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QuanLyHocPhan.Entity
{
    [Table("GiangVien")]
    public class GiangVien
    {
        [Key]
        [StringLength(50)]
        public string MSGV { get; set; }

        public string TenGV { get; set; }

        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

        public string HocHam { get; set; }

        public string HocVi { get; set; }

        public string Khoa { get; set; }

        public virtual ICollection<GV_HP> lsHP_GV { get; set; }
    }
}
