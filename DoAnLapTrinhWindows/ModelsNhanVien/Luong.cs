namespace DoAnLapTrinhWindows.ModelsNhanVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Luong")]
    public partial class Luong
    {
        [Key]
        [StringLength(5)]
        public string MaNV { get; set; }

        public decimal LuongCoBan { get; set; }

        public decimal? Thuong { get; set; }

        public decimal? Phat { get; set; }

        public decimal LuongThucNhan { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
