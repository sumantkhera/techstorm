namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MortgageLifePolicy
    {
        [Key]
        public int Lifepolicyid { get; set; }

        public int QuoteNo { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        public decimal? FaceValue { get; set; }

        [StringLength(50)]
        public string PolicyDuration { get; set; }

        public decimal? SurrenderValue { get; set; }
    }
}
