namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentInfo")]
    public partial class PaymentInfo
    {
        [Key]
        public int Pymnt_Id { get; set; }

        public int? Pymnt_BillId { get; set; }

        public int? Pymnt_QuoteNo { get; set; }

        [StringLength(5)]
        public string Pymnt_PlanCode { get; set; }

        [StringLength(3)]
        public string Pymnt_TrmCode { get; set; }

        [StringLength(1)]
        public string Pymnt_TrmType { get; set; }

        [StringLength(50)]
        public string Pymnt_Mode { get; set; }

        [StringLength(5)]
        public string Pymnt_BankId { get; set; }

        [StringLength(20)]
        public string Pymnt_CardNo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pymnt_Amount { get; set; }

        public DateTime? Pymnt_Date { get; set; }

        public bool? Pymnt_IsDone { get; set; }

        [StringLength(100)]
        public string Pymnt_Comment { get; set; }

        [StringLength(1)]
        public string Pymnt_PayeeType { get; set; }

        [StringLength(100)]
        public string Pymnt_PayeeName { get; set; }

        [StringLength(10)]
        public string Pymnt_CashierId { get; set; }

        public int? Pymnt_ReceiptNo { get; set; }

        [StringLength(2)]
        public string Pymnt_CardType { get; set; }

        [StringLength(100)]
        public string Pymnt_NameOnCard { get; set; }

        [StringLength(2)]
        public string Pymnt_ExpiryMonth { get; set; }

        [StringLength(4)]
        public string Pymnt_ExpiryYear { get; set; }

        [StringLength(4)]
        public string Pymnt_CVV { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pymnt_Commission { get; set; }

        [StringLength(20)]
        public string Pymnt_ProfitCenter { get; set; }

        [StringLength(1)]
        public string Pymnt_Type { get; set; }

        public int? Pymnt_BrokerReceiptNo { get; set; }

        public int? Pymnt_VoidReceiptNo { get; set; }

        public int? Pymnt_PrePaymentReceiptNo { get; set; }

        public int? Pymnt_NIReceiptNo { get; set; }

        [StringLength(1)]
        public string Pymnt_IsPrinted { get; set; }

        public int? Pymnt_NoOfPrints { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pymnt_BalanceAmount { get; set; }

        [StringLength(50)]
        public string Pymnt_RoutingNo { get; set; }

        [StringLength(25)]
        public string Pymnt_GLAccount { get; set; }

        public decimal? Pymnt_GovTax { get; set; }

        public bool? Pymnt_AML { get; set; }

        public decimal? Pymnt_PreTaxAmount { get; set; }

        public bool? Pymnt_RemittanceFlag { get; set; }

        public bool? Pymnt_ReconciledFlag { get; set; }

        public int? Pymnt_VoidBrokerReceiptNo { get; set; }

        public decimal? Pymnt_CommissionPercent { get; set; }

        public decimal? Pymnt_AmountPaid { get; set; }

        public decimal? Pymnt_NetPremium { get; set; }

        [StringLength(1)]
        public string Pymnt_PaymentType { get; set; }

        public virtual Billing Billing { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
