namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BatchSummary")]
    public partial class BatchSummary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BatchSummary()
        {
            BatchChequeDetails = new HashSet<BatchChequeDetail>();
            BatchChequeDetailsLogs = new HashSet<BatchChequeDetailsLog>();
        }

        [Key]
        public int BatchId { get; set; }

        public int? NoofCheques { get; set; }

        public DateTime? BatchPeriodFrom { get; set; }

        public DateTime? BatchPeriodTo { get; set; }

        [StringLength(1)]
        public string BatchPeriodType { get; set; }

        public int? ChequeStartRange { get; set; }

        public int? ChequeEndRange { get; set; }

        [StringLength(1)]
        public string BatchPrintStatus { get; set; }

        public DateTime? Trans_Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchChequeDetail> BatchChequeDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchChequeDetailsLog> BatchChequeDetailsLogs { get; set; }
    }
}
