namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolicyRiskPreference")]
    public partial class PolicyRiskPreference
    {
        public int Id { get; set; }

        public int? QuoteNo { get; set; }

        public int? RiskPrefId { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
