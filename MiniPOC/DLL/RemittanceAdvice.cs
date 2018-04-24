namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RemittanceAdvice")]
    public partial class RemittanceAdvice
    {
        [Key]
        public int RemittanceId { get; set; }

        [StringLength(1)]
        public string Broker_Type { get; set; }

        [StringLength(10)]
        public string Producer_Type { get; set; }

        [StringLength(100)]
        public string Producer_name { get; set; }

        public int? Recipt_No { get; set; }

        public decimal? Commision { get; set; }

        public decimal? Amount { get; set; }

        public decimal? Tax { get; set; }

        public decimal? Net_Amount { get; set; }

        public decimal? Pymnt_BalanceAmount { get; set; }

        [StringLength(2000)]
        public string DocumentPath { get; set; }

        [StringLength(50)]
        public string Pymnt_Mode { get; set; }

        [StringLength(5)]
        public string Pymnt_BankId { get; set; }

        [StringLength(20)]
        public string Pymnt_CardNo { get; set; }

        [StringLength(10)]
        public string Pymnt_CashierId { get; set; }

        [StringLength(2)]
        public string Pymnt_CardType { get; set; }

        [StringLength(100)]
        public string Pymnt_NameOnCard { get; set; }

        [StringLength(2)]
        public string Pymnt_ExpiryMonth { get; set; }

        [StringLength(4)]
        public string Pymnt_ExpiryYear { get; set; }

        [StringLength(50)]
        public string Pymnt_RoutingNo { get; set; }

        [StringLength(500)]
        public string Pymnt_Transaction_Desc { get; set; }

        public DateTime? Trans_Date { get; set; }

        [StringLength(1)]
        public string Pymnt_Stat { get; set; }

        [StringLength(100)]
        public string Pymnt_PayeeName { get; set; }
    }
}
