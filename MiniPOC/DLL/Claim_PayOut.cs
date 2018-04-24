namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Claim_PayOut
    {
        [Key]
        public int Clm_PayOutId { get; set; }

        public int Clm_ClaimNo { get; set; }

        [StringLength(500)]
        public string Clm_PayeeName { get; set; }

        public int? Clm_PayeeNameId { get; set; }

        [StringLength(1000)]
        public string Clm_Comments { get; set; }

        public int? Clm_ClaimantId { get; set; }

        [StringLength(500)]
        public string Clm_ClaimantName { get; set; }

        public int? Clm_ReserveLineId { get; set; }

        [StringLength(2)]
        public string Clm_ReserveType { get; set; }

        public decimal? Clm_Loss { get; set; }

        public decimal? Clm_Expense { get; set; }

        [StringLength(2)]
        public string Clm_ExpenseType { get; set; }

        [StringLength(2)]
        public string Clm_PaymentType { get; set; }

        [StringLength(5)]
        public string Clm_PaymentAgainst { get; set; }

        public DateTime? Clm_PaymentAgainstDate { get; set; }

        public decimal? Clm_PaymentAgainstAmount { get; set; }

        public decimal? Clm_GrossAmount { get; set; }

        public decimal? Clm_SalvageAmount { get; set; }

        public decimal? Clm_Excess { get; set; }

        public decimal? Clm_PreVatAmount { get; set; }

        public decimal? Clm_VATAmount { get; set; }

        public decimal? Clm_CheckAmount { get; set; }

        [StringLength(10)]
        public string Clm_VATRegNo { get; set; }

        [StringLength(10)]
        public string Clm_CheckNo { get; set; }

        public int? Clm_ClaimClaimant { get; set; }

        public decimal? Clm_Estimate { get; set; }

        [StringLength(10)]
        public string Clm_Payee { get; set; }

        [StringLength(25)]
        public string Clm_InvoiceNumber { get; set; }

        [StringLength(50)]
        public string Clm_Institution { get; set; }

        [StringLength(1)]
        public string Clm_IsHoldPayment { get; set; }

        public int? Clm_ItemCovered { get; set; }

        public DateTime? Clm_FuturePaymentDate { get; set; }

        public decimal? Clm_VatPercentage { get; set; }

        public DateTime? Clm_TransDate { get; set; }

        public decimal? Clm_LegalExpense { get; set; }

        public decimal? Clm_GeneralDamage { get; set; }

        public decimal? Clm_SpecialDamage { get; set; }

        [StringLength(1000)]
        public string Clm_Address1 { get; set; }

        public int? Clm_City { get; set; }

        [StringLength(20)]
        public string Clm_Phone { get; set; }

        public int? Clm_ReceiptNo { get; set; }

        public bool? Clm_ReverseStatus { get; set; }

        public decimal? Clm_Parts { get; set; }

        public decimal? Clm_Labour { get; set; }

        public decimal? Clm_Adjusters { get; set; }

        public decimal? Clm_Investigators { get; set; }

        [StringLength(10)]
        public string Clm_User { get; set; }

        public virtual Claim_ClaimantItemDetail Claim_ClaimantItemDetail { get; set; }

        public virtual Claim_Occurence Claim_Occurence { get; set; }

        public virtual Claim_ReserveDetails Claim_ReserveDetails { get; set; }
    }
}
