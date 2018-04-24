namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_BrokerCommissions
    {
        [Key]
        public int CommissionId { get; set; }

        [StringLength(10)]
        public string Cmm_BrokerCode { get; set; }

        [StringLength(4)]
        public string Cmm_PropCode { get; set; }

        public decimal? Cmm_CommissionPercent { get; set; }

        public DateTime? Cmm_EffectiveDate { get; set; }

        public DateTime? Cmm_ExpiryDate { get; set; }

        [StringLength(10)]
        public string Cmm_LastModifyBy { get; set; }

        public DateTime? Cmm_LastModifyDate { get; set; }

        public virtual MST_ProducerName MST_ProducerName { get; set; }

        public virtual Mst_Proposal Mst_Proposal { get; set; }
    }
}
