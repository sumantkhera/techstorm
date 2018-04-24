namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BatchChequeDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BatchChequeDetail()
        {
            BatchChequeDetailsLogs = new HashSet<BatchChequeDetailsLog>();
        }

        [Key]
        public int BatchChequeId { get; set; }

        public int? BatchId { get; set; }

        [StringLength(25)]
        public string ClaimNo { get; set; }

        [StringLength(25)]
        public string PolicyNo { get; set; }

        [StringLength(500)]
        public string Cheque_PayeeName { get; set; }

        public decimal? Cheque_Amount { get; set; }

        public DateTime? Cheque_PayDate { get; set; }

        [StringLength(10)]
        public string Cheque_Number { get; set; }

        [StringLength(5)]
        public string Cheque_Status { get; set; }

        [StringLength(10)]
        public string Old_Cheque_No { get; set; }

        [StringLength(1)]
        public string IsPrinted { get; set; }

        public int? NoofPrints { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(10)]
        public string EnteredBy { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(500)]
        public string Cheque_Comment { get; set; }

        public virtual BatchSummary BatchSummary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchChequeDetailsLog> BatchChequeDetailsLogs { get; set; }
    }
}
