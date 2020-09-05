namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
       
        public int ID { get; set; }
        [DisplayName("Ten Danh Muc")]
        [StringLength(50,ErrorMessage ="Toi Da 50 ky tu")]
        [Required(ErrorMessage ="Ban chua nhap ten")]
        public string Name { get; set; }
        [DisplayName("Tieu De SEO")]
        [StringLength(50)]
        public string Alias { get; set; }
        [DisplayName("Danh Muc Cha")]
        public int? ParentID { get; set; }
        [DisplayName("Ngay Tao")]
        public DateTime? CreatedDate { get; set; }
        [DisplayName("Sl Dat")]
        [Range(0,Int32.MaxValue,ErrorMessage ="ban phai nhap so")]
        public int? Order { get; set; }
        [DisplayName("Trang Thai")]
        public bool? Status { get; set; }
        
    }
}
