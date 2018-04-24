namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Range
    {
        [Key]
        public int Rng_ID { get; set; }

        [StringLength(4)]
        public string Rng_ProposalCode { get; set; }

        public int? Rng_Quote_Start { get; set; }

        public int? Rng_Quote_Current { get; set; }

        public int? Rng_Quote_End { get; set; }

        public int? Rng_App_Start { get; set; }

        public int? Rng_App_Current { get; set; }

        public int? Rng_App_End { get; set; }

        public int? Rng_ModifyBy { get; set; }

        public DateTime? Rng_ModifyDate { get; set; }

        public bool? Rng_IsActive { get; set; }

        public int? Rng_Invoice_Start { get; set; }

        public int? Rng_Invoice_Current { get; set; }

        public int? Rng_Invoice_End { get; set; }

        public int? Rng_TransSeq_Start { get; set; }

        public int? Rng_TransSeq_Current { get; set; }

        public int? Rng_TransSeq_End { get; set; }

        public int? Rng_RecieptNo_Start { get; set; }

        public int? Rng_RecieptNo_Current { get; set; }

        public int? Rng_RecieptNo_End { get; set; }
    }
}
