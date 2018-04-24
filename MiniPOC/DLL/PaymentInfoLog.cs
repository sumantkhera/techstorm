namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentInfoLog")]
    public partial class PaymentInfoLog
    {
        [Key]
        public int Log_Id { get; set; }

        public int? Pymnt_Id { get; set; }

        public int? Pymnt_QuoteNo { get; set; }

        [StringLength(1)]
        public string Pymnt_Type { get; set; }

        [StringLength(50)]
        public string Pymnt_Mode { get; set; }

        [StringLength(5)]
        public string Pymnt_BankId { get; set; }

        [StringLength(2)]
        public string Pymnt_CardType { get; set; }

        [StringLength(20)]
        public string Pymnt_CardNo { get; set; }

        [StringLength(100)]
        public string Pymnt_NameOnCard { get; set; }

        [StringLength(2)]
        public string Pymnt_ExpiryMonth { get; set; }

        [StringLength(4)]
        public string Pymnt_ExpiryYear { get; set; }

        [StringLength(100)]
        public string Pymnt_PayeeName { get; set; }

        [StringLength(20)]
        public string Pymnt_ProfitCenter { get; set; }

        public int? Pymnt_ReceiptNo { get; set; }

        [StringLength(500)]
        public string Pymnt_VoidComment { get; set; }

        [StringLength(10)]
        public string Pymnt_CashierId { get; set; }

        public DateTime? Trans_Date { get; set; }
    }
}
