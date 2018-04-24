namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction_Details
    {
        [Key]
        public int TransID { get; set; }

        public int? Trans_Quoteno { get; set; }

        [StringLength(10)]
        public string Trans_PolicyPrefix { get; set; }

        [StringLength(25)]
        public string Trans_PolicyNumber { get; set; }

        [StringLength(2)]
        public string Trans_Type { get; set; }

        public DateTime? Trans_Date { get; set; }

        [StringLength(1000)]
        public string Trans_Comments { get; set; }

        public decimal? Trans_Premium { get; set; }

        [StringLength(5)]
        public string Trans_Reason { get; set; }

        public DateTime? Trans_EffectiveDate { get; set; }

        public DateTime? Trans_ExpiryDate { get; set; }

        public DateTime? Trans_UserId { get; set; }

        public DateTime? Trans_UpdatedDate { get; set; }

        public virtual Mst_TransType Mst_TransType { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }
    }
}
