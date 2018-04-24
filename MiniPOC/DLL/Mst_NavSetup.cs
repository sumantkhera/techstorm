namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_NavSetup
    {
        [Key]
        public int NavId { get; set; }

        public bool? Nav_Fronting { get; set; }

        [StringLength(1)]
        public string Nav_LobCode { get; set; }

        [StringLength(4)]
        public string Nav_ProposalCode { get; set; }

        [StringLength(3)]
        public string Nav_ProducerType { get; set; }

        [StringLength(20)]
        public string Nav_ProfitCenter { get; set; }

        [StringLength(1)]
        public string Nav_CustomerType { get; set; }

        [StringLength(50)]
        public string Nav_Debit_AccountTypeCode { get; set; }

        [StringLength(200)]
        public string Nav_Debit_AccountTypeValue { get; set; }

        [StringLength(50)]
        public string Nav_Debit_AccountNoCode { get; set; }

        [Required]
        [StringLength(200)]
        public string Nav_Debit_AccountNoValue { get; set; }

        [StringLength(50)]
        public string Nav_Credit_AccountTypeCode { get; set; }

        [StringLength(200)]
        public string Nav_Credit_AccountTypeValue { get; set; }

        [StringLength(50)]
        public string Nav_Credit_AccountNoCode { get; set; }

        [StringLength(200)]
        public string Nav_Credit_AccountNoValue { get; set; }

        public bool? Nav_IsActive { get; set; }

        public DateTime? Nav_CreatedAt { get; set; }

        public int? Nav_ParentId { get; set; }
    }
}
