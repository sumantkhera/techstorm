namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Billing")]
    public partial class Billing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Billing()
        {
            PaymentInfoes = new HashSet<PaymentInfo>();
        }

        [Key]
        public int Bill_Id { get; set; }

        public int? PremId { get; set; }

        public int? QuoteNo { get; set; }

        [StringLength(5)]
        public string Plan_Code { get; set; }

        [StringLength(3)]
        public string Plan_TrmCode { get; set; }

        [StringLength(1)]
        public string Plan_TrmType { get; set; }

        [StringLength(50)]
        public string Trans_Type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pay_Amount { get; set; }

        public DateTime? Due_Date { get; set; }

        public DateTime? Cancel_Date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pay_Fee1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pay_Fee2 { get; set; }

        [StringLength(1)]
        public string Pay_Adjust { get; set; }

        public DateTime? Adjust_Date { get; set; }

        public DateTime? Pymnt_Date { get; set; }

        public int? Pre_Bill_Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pay_GovTax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pay_Comm { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pay_WithoutTax { get; set; }

        public decimal? CommissionPercent { get; set; }

        public decimal? Pay_AmountPaid { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }

        public virtual PremiumInfo PremiumInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentInfo> PaymentInfoes { get; set; }
    }
}
