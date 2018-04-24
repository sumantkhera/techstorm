namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FundSchemeValue")]
    public partial class FundSchemeValue
    {
        public int Id { get; set; }

        public int? QuoteNo { get; set; }

        [StringLength(500)]
        public string FundSchemeName { get; set; }

        public decimal? Value { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
