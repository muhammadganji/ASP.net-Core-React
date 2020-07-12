using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Models
{
    public class DCandidate
    {
        [Key]
        public int id { get; set; }
        //[Display(Name = "نام کامل")]
        [Column(TypeName = "nvarchar(100)")]
        public string fullname { get; set; }

        //[Display(Name = "موبایل")]
        [Column(TypeName = "nvarchar(16)")]
        public string mobile { get; set; }

        //[Display(Name = "ایمیل")]
        [Column(TypeName = "nvarchar(100)")]
        public string email { get; set; }

        //[Display(Name = "گروه خونی")]
        [Column(TypeName = "nvarchar(3)")]
        public string bloodgroup { get; set; }

        //[Display(Name = "آدرس")]
        [Column(TypeName = "nvarchar(100)")]
        public string address { get; set; }

        //[Display(Name = "سن")]
        public int age { get; set; }

    }
}
