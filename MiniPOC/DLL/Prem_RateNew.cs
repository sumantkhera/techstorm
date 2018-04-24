namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Prem_RateNew
    {
        [Key]
        public int PremId { get; set; }

        public int? QuoteNo { get; set; }

        public int? Unit_ID { get; set; }

        public int? Unit_Seq { get; set; }

        [StringLength(20)]
        public string SD_Master_Code { get; set; }

        [StringLength(20)]
        public string SD_SubMaster_Code { get; set; }

        [StringLength(20)]
        public string SD_Code { get; set; }

        [StringLength(150)]
        public string SD_Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Base_Prem { get; set; }

        [StringLength(10)]
        public string SD_Type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SD_Fact { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SD_Amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Total_Prem { get; set; }

        public int? RelationId { get; set; }

        [StringLength(20)]
        public string SD_SubCode { get; set; }

        public int? QuoteNoRef { get; set; }

        [StringLength(2)]
        public string InputType { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? EffectiveDate { get; set; }

        [StringLength(2)]
        public string TransType { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
