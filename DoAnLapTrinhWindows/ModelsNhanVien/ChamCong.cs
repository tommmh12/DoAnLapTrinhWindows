namespace DoAnLapTrinhWindows.ModelsNhanVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChamCong")]
    public partial class ChamCong
    {
        [Key]
        public int MaCC { get; set; }

        [Required]
        [StringLength(5)]
        public string MaNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
