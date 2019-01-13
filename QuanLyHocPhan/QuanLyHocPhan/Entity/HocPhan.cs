using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QuanLyHocPhan.Entity
{
    [Table("HocPhan")]
    public class HocPhan
    {
        [Key][StringLength(50)]
        public string MSHP { get; set; }

        public string TenHP { get; set; }

        public virtual ICollection<GV_HP> lsHP_GV { get; set; }
    }
}
