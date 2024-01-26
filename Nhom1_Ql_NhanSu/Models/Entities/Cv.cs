using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Nhom1_Ql_NhanSu.Models.Entities
{
    public partial class Cv
    {
        [Display(Name = "Mã CV")]
        public string MaCv { get; set; }
        [Display(Name = "Họ Tên")]
        public string HoTen { get; set; }
        [Display(Name = "Giới Tính")]
        public string GioiTinh { get; set; }
        [Display(Name = "Ngày Sinh")]
        public DateTime NgaySinh { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Số Điện Thoại")]
        public string Sdt { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "Công Việc Ứng Tuyển")]
        public string CongViec { get; set; }
        [Display(Name = "Trình độ học vấn")]
        public string TrinhDoHocVan { get; set; }
        [Display(Name = "Ngày nộp CV")]
        public DateTime NgayNopCv { get; set; }
        [Display(Name = "Tình Trạng")]
        public string TinhTrang { get; set; }
        
    }
}
