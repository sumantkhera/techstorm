namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VoucherDetail
    {
        [Key]
        public int VoucherId { get; set; }

        public int? VoucherNo { get; set; }

        public int? Voucher_ChequeRefId { get; set; }

        [StringLength(25)]
        public string ClaimNo { get; set; }

        [StringLength(25)]
        public string PolicyNo { get; set; }

        [StringLength(500)]
        public string Voucher_PayeeName { get; set; }

        public decimal? Voucher_Amount { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(10)]
        public string EnteredBy { get; set; }

        public int? Voucher_MergeChequeId { get; set; }
    }
}
