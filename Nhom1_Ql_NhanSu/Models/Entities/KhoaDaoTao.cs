using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Nhom1_Ql_NhanSu.Models.Entities
{
    public partial class KhoaDaoTao
    {
        [Display(Name = "Mã Khoa")]
        public int MaKhoa { get; set; }
        [Display(Name = "Tên Khoa")]
        public string TenKhoa { get; set; }
        [Display(Name = "Mô Tả")]
        public string MoTa { get; set; }
        [Display(Name = "Thời Gian Bắt Đầu")]
        public DateTime ThoiGianBatDau { get; set; }
        [Display(Name = "Thời Gian Kết Thúc")]
        public DateTime ThoiGianKetThuc { get; set; }
    }
}
