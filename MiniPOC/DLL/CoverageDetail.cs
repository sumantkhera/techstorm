namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CoverageDetail
    {
        public int Id { get; set; }

        public int? QuoteNo { get; set; }

        public decimal? AnnualContri { get; set; }

        [StringLength(50)]
        public string FrequencyOfPay { get; set; }

        [StringLength(50)]
        public string ModeOfPay { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
