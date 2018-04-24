namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolicyInvestmentApproach")]
    public partial class PolicyInvestmentApproach
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string PooledInvFund { get; set; }

        public int? QuoteNo { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
