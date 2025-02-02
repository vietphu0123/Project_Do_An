﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    public class User
    {
        public User()
        {
           
            this.Order = new HashSet<Order>();
        }
        [Key]
        public int id_Name_User { get; set; }
        public string Name { get; set; }
        public string SDT { get; set; }
        public string Dia_Chi { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "Date")]
        public System.Nullable<DateTime> Ngay_Sinh { get; set; }
        public System.Nullable<bool> Gioi_Tinh { get; set; }
        [Index(IsUnique = true)]
        public int idTaiKhoan { get; set; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual ICollection<Order> Order { get; set; }

    }
}
