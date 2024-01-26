using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Nhom1_Ql_NhanSu.Models.Entities
{
    public partial class Kpi1
    {
        [Display(Name = "ID")]
        public string Id { get; set; }
        [Display(Name = "Họ Tên")]
        public string HoTen { get; set; }
        [Display(Name = "Chức Vụ")]
        public string ChucVu { get; set; }
        [Display(Name = "Đi Làm Đúng Giờ")]
        public string DiLamDungGio { get; set; }
        [Display(Name = "Đi làm Đầy Đủ")]
        public string DiLamDayDu { get; set; }
        [Display(Name = "Hoàn Thành Tốt Công Việc")]
        public string HoanThanhTotCongViec { get; set; }
        [Display(Name = "Đánh giá KPI")]
        public string DanhGiaKpi { get; set; }
    }
}
