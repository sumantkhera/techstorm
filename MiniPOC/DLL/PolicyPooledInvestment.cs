namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolicyPooledInvestment")]
    public partial class PolicyPooledInvestment
    {
        public int Id { get; set; }

        public int? QuoteNo { get; set; }

        public int? PIFId { get; set; }

        public decimal? Percentage { get; set; }

        public virtual Mst_InvestmentApproach Mst_InvestmentApproach { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
