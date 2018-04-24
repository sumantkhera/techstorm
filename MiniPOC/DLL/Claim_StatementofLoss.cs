namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Claim_StatementofLoss
    {
        [Key]
        public int PlateGlassId { get; set; }

        public int? Clm_GlassDetailId { get; set; }

        [StringLength(500)]
        public string Clm_GlassDetail { get; set; }

        public decimal? Clm_PresentValue { get; set; }

        public int Clm_ClaimNo { get; set; }

        [StringLength(500)]
        public string Clm_PropDesc { get; set; }

        public decimal? Clm_LossEst { get; set; }

        [StringLength(500)]
        public string Clm_DamageDesc { get; set; }

        [StringLength(50)]
        public string Clm_CarrierList { get; set; }

        [StringLength(50)]
        public string Clm_PolicyNo { get; set; }

        [StringLength(50)]
        public string Clm_OtherInfo { get; set; }

        [StringLength(1)]
        public string Clm_IsRepairable { get; set; }

        public int? Clm_Location { get; set; }

        [StringLength(10)]
        public string Clm_PropertyMortgaged { get; set; }

        [StringLength(100)]
        public string Clm_Examiner { get; set; }

        [StringLength(10)]
        public string Clm_ExaminerName { get; set; }

        public DateTime? Clm_ExaminerDate { get; set; }

        [StringLength(100)]
        public string Clm_Adjuster { get; set; }

        [StringLength(10)]
        public string Clm_AdjusterName { get; set; }

        public DateTime? Clm_AdjusterDate { get; set; }

        [StringLength(100)]
        public string Clm_Investigator { get; set; }

        [StringLength(10)]
        public string Clm_InvestigatorName { get; set; }

        public DateTime? Clm_InvestigatorDate { get; set; }

        public DateTime? Clm_InvestigatorRetDate { get; set; }

        public DateTime? Clm_AdjusterRetDate { get; set; }

        public decimal? Clm_BuildingSumInsured { get; set; }

        public decimal? Clm_ItemSumInsured { get; set; }

        public decimal? Clm_ContentSumInsured { get; set; }

        public decimal? Clm_AllRiskSumInsured { get; set; }

        [StringLength(500)]
        public string Clm_LocationValue { get; set; }

        public int? Clm_BuildingSeqNo { get; set; }

        [StringLength(1)]
        public string Clm_CLoss { get; set; }

        [StringLength(100)]
        public string Clm_ManufacturerName { get; set; }

        public int? Clm_NoOfMachines { get; set; }

        public int? Clm_ManufacturingYear { get; set; }

        [StringLength(50)]
        public string Clm_SerialNumber { get; set; }

        [StringLength(50)]
        public string Clm_TransitMethod { get; set; }

        [StringLength(1)]
        public string Clm_ClassGroup { get; set; }

        public DateTime? Clm_DateofPurchase { get; set; }

        public decimal? Clm_CostPrice { get; set; }

        public decimal? Clm_SalvageValue { get; set; }

        public decimal? Clm_NetAmountClaimed { get; set; }

        public decimal? Clm_LabourCost { get; set; }

        public decimal? Clm_MaterialCost { get; set; }

        public decimal? Clm_EstimatedDamage { get; set; }

        [StringLength(10)]
        public string Clm_ItemsCoveredValue { get; set; }

        [StringLength(500)]
        public string Clm_ItemsCoveredText { get; set; }

        [StringLength(50)]
        public string Clm_NatureOfPacking { get; set; }

        public decimal? Clm_OriginalLoanAmount { get; set; }

        public decimal? Clm_OutstandingLoanAmount { get; set; }

        public DateTime? Clm_EffectiveDateOfInsurance { get; set; }

        [StringLength(20)]
        public string Clm_LoanAccountNumber { get; set; }

        public decimal? Clm_AppliedCoverageAmount { get; set; }

        public int? Clm_TotalNoOfMonths { get; set; }

        [StringLength(100)]
        public string ClmAttachment { get; set; }

        public int? TypeId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DisabilityPercentage { get; set; }

        public virtual Claim_Occurence Claim_Occurence { get; set; }
    }
}
