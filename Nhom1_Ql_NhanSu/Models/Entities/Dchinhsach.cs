using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Nhom1_Ql_NhanSu.Models.Entities
{
    public partial class Dchinhsach
    {
        public string Id { get; set; }
        [Display(Name = "Nội Dung")]
        public string Text { get; set; }
        [Display(Name = "Phân Loại")]
        public string Class { get; set; }
    }
}
