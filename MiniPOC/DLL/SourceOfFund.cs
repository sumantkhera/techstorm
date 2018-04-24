namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SourceOfFund")]
    public partial class SourceOfFund
    {
        public int Id { get; set; }

        public int? QuoteNo { get; set; }

        [StringLength(10)]
        public string Contribution { get; set; }

        [StringLength(50)]
        public string SalaryTransferType { get; set; }

        public decimal? AnnualIncomeEm { get; set; }

        [StringLength(10)]
        public string TransferValue { get; set; }

        [StringLength(50)]
        public string Other { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
