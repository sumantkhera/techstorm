namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_PolicyClass
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string policy_type_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string class_type { get; set; }

        [StringLength(50)]
        public string policy_type_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string country_code { get; set; }

        [StringLength(4)]
        public string policy_PropCode { get; set; }

        [StringLength(10)]
        public string cert_type { get; set; }

        public decimal? gov_tax { get; set; }

        [StringLength(150)]
        public string cert_text1 { get; set; }

        [StringLength(150)]
        public string cert_text2 { get; set; }

        [StringLength(150)]
        public string cert_text3 { get; set; }

        [StringLength(150)]
        public string cert_text4 { get; set; }

        [StringLength(150)]
        public string cert_text5 { get; set; }

        [StringLength(150)]
        public string cert_text6 { get; set; }

        [StringLength(150)]
        public string cert_text7 { get; set; }

        [StringLength(150)]
        public string cert_text8 { get; set; }

        [StringLength(1)]
        public string gl_class { get; set; }

        [StringLength(4)]
        public string old_type { get; set; }

        [StringLength(1)]
        public string stamp_duty { get; set; }

        [StringLength(4)]
        public string policy_code { get; set; }

        [StringLength(1)]
        public string grouping_code { get; set; }

        [StringLength(1)]
        public string app_business_class { get; set; }

        [StringLength(1)]
        public string marine_type { get; set; }

        public short? cb_group_no { get; set; }

        [StringLength(15)]
        public string form_name { get; set; }

        [StringLength(1000)]
        public string Extra { get; set; }

        [StringLength(1)]
        public string PC_status { get; set; }

        [StringLength(10)]
        public string PC_LastModifyBy { get; set; }

        public DateTime? PC_LastModifyDate { get; set; }
    }
}
