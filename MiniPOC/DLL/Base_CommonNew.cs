namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_CommonNew
    {
        [Key]
        public int SD_ID { get; set; }

        [StringLength(4)]
        public string SD_Porp_Code { get; set; }

        [StringLength(50)]
        public string ProposerType { get; set; }

        [StringLength(20)]
        public string SD_Master_Code { get; set; }

        [StringLength(20)]
        public string SD_SubMaster_Code { get; set; }

        [StringLength(20)]
        public string SD_Code { get; set; }

        [StringLength(20)]
        public string SD_SubCode { get; set; }

        [StringLength(20)]
        public string SD_SubCode1 { get; set; }

        public int? SD_MinAge { get; set; }

        public int? SD_MaxAge { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SD_Factor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SD_Fact_Amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SD_StartLimit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SD_EndLimit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SD_Fact_Division { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SD_MinLimit { get; set; }

        [StringLength(10)]
        public string SD_Type { get; set; }

        [StringLength(150)]
        public string SD_Description { get; set; }

        public bool? SD_Stat { get; set; }

        [StringLength(5)]
        public string BusinessType { get; set; }

        [StringLength(20)]
        public string SD_ProducerCode { get; set; }

        public DateTime Cmn_NewDate { get; set; }

        public DateTime Cmn_EndDate { get; set; }

        [StringLength(10)]
        public string Cmn_LastModifyBy { get; set; }

        public DateTime? Cmn_LastModifyDate { get; set; }
    }
}
