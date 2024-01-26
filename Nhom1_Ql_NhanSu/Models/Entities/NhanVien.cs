using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace QL_NhanSu_nhom1.Models.NhanVien
{
    public partial class NhanVien
    {
        [Display(Name = "Mã nhân viên")]
        public string MaNv { get; set; }

        [Display(Name = "Họ tên")]
        public string Hoten { get; set; }

        [Display(Name = "Giới tính")]
        public string GioiTinh { get; set; }

        [Display(Name = "Ngày sinh")]
        public DateTime? NgaySinh { get; set; }
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        public string Sdt { get; set; }

        [Display(Name = "Địa chỉ")]
        public string Diachi { get; set; }

        [Display(Name = "Chức vụ")]
        public string Chucvu { get; set; }

        [Display(Name = "Trạng thái")]
        public string TrangthaiNv { get; set; }
    }
}
