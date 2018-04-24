namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Branch
    {
        [Key]
        public int branch_id { get; set; }

        [Required]
        [StringLength(10)]
        public string branch_code { get; set; }

        [Required]
        [StringLength(10)]
        public string producer_code { get; set; }

        public int? terms_code { get; set; }

        [StringLength(1)]
        public string binder { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? comm_percent { get; set; }

        [StringLength(100)]
        public string branch_name { get; set; }

        [StringLength(100)]
        public string address1 { get; set; }

        [StringLength(100)]
        public string address2 { get; set; }

        [StringLength(100)]
        public string address3 { get; set; }

        [StringLength(100)]
        public string address4 { get; set; }

        [StringLength(15)]
        public string tel_no1 { get; set; }

        [StringLength(15)]
        public string tel_no2 { get; set; }

        [StringLength(15)]
        public string fax_no { get; set; }

        [StringLength(20)]
        public string policy_code { get; set; }

        [StringLength(20)]
        public string acct_no { get; set; }

        [StringLength(1)]
        public string IsActive { get; set; }

        [StringLength(10)]
        public string LastModifyBy { get; set; }

        public DateTime? LastModifyDate { get; set; }

        public bool? IsYesNoVisible { get; set; }

        public virtual MST_ProducerName MST_ProducerName { get; set; }
    }
}
