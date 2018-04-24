namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CoinsuranceDetail
    {
        [Key]
        public int CoinsuranceId { get; set; }

        [StringLength(50)]
        public string Coins_CompanyName { get; set; }

        public int? Coins_QuoteNo { get; set; }

        public decimal? Coins_Percentage { get; set; }

        public int? Coins_CompId { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
