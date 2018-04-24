namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NavPayment
    {
        [Key]
        public int NavPymntId { get; set; }

        public int? Nav_PaymentId { get; set; }

        public int? Nav_RefrenceNo { get; set; }

        [StringLength(30)]
        public string Nav_RefrenceType { get; set; }

        [StringLength(50)]
        public string Nav_JournalTemplateName { get; set; }

        public int? Nav_LineNo { get; set; }

        [StringLength(50)]
        public string Nav_AccountType { get; set; }

        [StringLength(50)]
        public string Nav_AccountNo { get; set; }

        public DateTime? Nav_PostingDate { get; set; }

        [StringLength(50)]
        public string Nav_DocumentNo { get; set; }

        [StringLength(100)]
        public string Nav_Description { get; set; }

        public decimal? Nav_Amount { get; set; }

        [StringLength(50)]
        public string Nav_PostingGroup { get; set; }

        [StringLength(50)]
        public string Nav_JournalBatchName { get; set; }

        public DateTime? Nav_DocumentDate { get; set; }

        [StringLength(50)]
        public string Nav_ExternalDocumentNo { get; set; }

        public int? Nav_NavSetupId { get; set; }

        [StringLength(2)]
        public string Nav_Type { get; set; }

        [StringLength(1)]
        public string Nav_IsPosted { get; set; }

        public DateTime? Nav_PostedDate { get; set; }

        [StringLength(10)]
        public string Nav_PostedUserId { get; set; }
    }
}
