namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiseaseDetailsTemp")]
    public partial class DiseaseDetailsTemp
    {
        [Key]
        public int DiseaseId { get; set; }

        public int? QuoteNo { get; set; }

        public int? DiseaseRefId { get; set; }

        public bool? Value { get; set; }

        public DateTime? TransactionDate { get; set; }

        public int? PersonalInfoId { get; set; }
    }
}
