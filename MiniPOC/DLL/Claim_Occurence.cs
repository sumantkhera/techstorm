namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Claim_Occurence
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Claim_Occurence()
        {
            Claim_AdjusterNotes = new HashSet<Claim_AdjusterNotes>();
            Claim_ClaimantItemDetail = new HashSet<Claim_ClaimantItemDetail>();
            Claim_Name = new HashSet<Claim_Name>();
            Claim_PayOut = new HashSet<Claim_PayOut>();
            Claim_ReinsuranceTransaction = new HashSet<Claim_ReinsuranceTransaction>();
            Claim_ReserveDetails = new HashSet<Claim_ReserveDetails>();
            Claim_ReserveHistory = new HashSet<Claim_ReserveHistory>();
            Claim_StatementofLoss = new HashSet<Claim_StatementofLoss>();
            ClaimAddOnCoverages = new HashSet<ClaimAddOnCoverage>();
            ClaimDocuments = new HashSet<ClaimDocument>();
            ClaimStatus = new HashSet<ClaimStatu>();
            DiaryNotes = new HashSet<DiaryNote>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clm_ClaimNo { get; set; }

        [StringLength(4)]
        public string Clm_ProposalCd { get; set; }

        [StringLength(10)]
        public string Clm_PolPrfx { get; set; }

        [StringLength(25)]
        public string Clm_PolNo { get; set; }

        [StringLength(10)]
        public string Clm_AgentID { get; set; }

        public DateTime? Clm_LossDt { get; set; }

        [StringLength(50)]
        public string Clm_TheftClaim { get; set; }

        public DateTime? Clm_EffectiveDt { get; set; }

        public DateTime? Clm_ExpiryDt { get; set; }

        public DateTime? Clm_ReportDt { get; set; }

        public int? Clm_CatostrapheId { get; set; }

        [StringLength(50)]
        public string Clm_Catostraphe { get; set; }

        [StringLength(4)]
        public string Clm_AcdntCountry { get; set; }

        [StringLength(15)]
        public string Clm_ReportNo { get; set; }

        public decimal? Clm_EstAmt { get; set; }

        [StringLength(1000)]
        public string Clm_AcdntDesc { get; set; }

        public DateTime? Clm_ClosedDt { get; set; }

        public int? Clm_DrvId { get; set; }

        public DateTime? Clm_AcdntDt { get; set; }

        public int? Clm_ExaminerID { get; set; }

        public int? Clm_AdjusterID { get; set; }

        [StringLength(50)]
        public string Clm_LosRepBy { get; set; }

        public int? Clm_VehicleID { get; set; }

        [StringLength(50)]
        public string Clm_VehColor { get; set; }

        [StringLength(15)]
        public string Clm_VehRegNo { get; set; }

        [StringLength(1)]
        public string Clm_ReportOnly { get; set; }

        public int? Clm_LossId { get; set; }

        [StringLength(1)]
        public string Clm_IsPoliceNotified { get; set; }

        [StringLength(100)]
        public string Clm_VehDamageDesc { get; set; }

        [StringLength(100)]
        public string Clm_PoliceRepPath { get; set; }

        [StringLength(3)]
        public string Claim_Status { get; set; }

        public DateTime? Claim_UpdateTime { get; set; }

        [StringLength(25)]
        public string Claim_Usr { get; set; }

        public int? Clm_LocId { get; set; }

        public int? Clm_InsuredVehicleDriver { get; set; }

        public int? Clm_ThirdPartyVehicleDriver { get; set; }

        public int? Clm_Pedestrain { get; set; }

        public int? Clm_InsuredVehicleThirdParty { get; set; }

        [StringLength(1000)]
        public string Clm_Address1 { get; set; }

        public int? Clm_ZoneId { get; set; }

        public int? Clm_AreaId { get; set; }

        public int? Clm_BlockId { get; set; }

        public int? Clm_RiskId { get; set; }

        public DateTime? Clm_SignatureDate { get; set; }

        [StringLength(5)]
        public string Clm_AtFault { get; set; }

        [StringLength(5)]
        public string Clm_LitigationStatus { get; set; }

        [StringLength(50)]
        public string Clm_HighCourtNoticeNumber { get; set; }

        public DateTime? Clm_DateOfAction { get; set; }

        [StringLength(500)]
        public string Clm_AccidentRepPath { get; set; }

        [StringLength(1)]
        public string Clm_Subrogation { get; set; }

        public bool? Clm_IsBussinessAddress { get; set; }

        public int? Clm_QuoteNo { get; set; }

        [StringLength(25)]
        public string Clm_PermanentClaimNo { get; set; }

        public DateTime? Clm_DateFiled { get; set; }

        public DateTime? Clm_DateServed { get; set; }

        public DateTime? Clm_NextDate { get; set; }

        public int? Clm_OurAtorney { get; set; }

        public int? Clm_ThirdAttorney { get; set; }

        [StringLength(500)]
        public string Clm_WorkDesc { get; set; }

        [StringLength(25)]
        public string Clm_OtherPolNo { get; set; }

        [StringLength(25)]
        public string Clm_FNamePersonBlamed { get; set; }

        [StringLength(25)]
        public string Clm_MNamePersonBlamed { get; set; }

        [StringLength(25)]
        public string Clm_LNamePersonBlamed { get; set; }

        [StringLength(1)]
        public string Clm_SexPersonBlamed { get; set; }

        [StringLength(1000)]
        public string Clm_AdressPersonBlamed { get; set; }

        [StringLength(4)]
        public string Clm_CountryPersonBlamed { get; set; }

        public int? Clm_ZoneIdPersonBlamed { get; set; }

        public int? Clm_AreaIdPersonBlamed { get; set; }

        public int? Clm_BlockIdPersonBlamed { get; set; }

        public int? Clm_RiskIdPersonBlamed { get; set; }

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

        [StringLength(50)]
        public string Clm_CarrierList { get; set; }

        [StringLength(10)]
        public string Clm_OtherInfo { get; set; }

        [StringLength(4)]
        public string Clm_LOBType { get; set; }

        [StringLength(5)]
        public string Clm_LocationType { get; set; }

        public int? Clm_Excess { get; set; }

        public int? Clm_CatastropheNo { get; set; }

        [StringLength(1000)]
        public string Clm_LossStreetAddress { get; set; }

        [StringLength(4)]
        public string Clm_LossCountryId { get; set; }

        public int? Clm_LossZoneId { get; set; }

        public int? Clm_LossAreaId { get; set; }

        public int? Clm_LossBlockId { get; set; }

        public int? Clm_LossRiskId { get; set; }

        [StringLength(100)]
        public string Clm_Item { get; set; }

        [StringLength(1000)]
        public string Clm_IncidentNature { get; set; }

        public int? Clm_BldId { get; set; }

        [StringLength(10)]
        public string Clm_SubrogationId { get; set; }

        [StringLength(10)]
        public string Clm_PerilCode { get; set; }

        [StringLength(5)]
        public string Clm_StatusCode { get; set; }

        public DateTime? Clm_StatusDate { get; set; }

        [StringLength(500)]
        public string Clm_StatusComments { get; set; }

        [StringLength(50)]
        public string Clm_InsurClaimNo { get; set; }

        [StringLength(20)]
        public string Clm_Zip { get; set; }

        [StringLength(20)]
        public string Clm_ZipPersonBlamed { get; set; }

        public int? Clm_MemberId { get; set; }

        public string Clm_PatientDiagnosis { get; set; }

        public DateTime? Clm_DiagnosisDate { get; set; }

        public DateTime? Clm_SymptomDate { get; set; }

        [StringLength(10)]
        public string Clm_IsSimilarCondition { get; set; }

        public string Clm_ConditionDetail { get; set; }

        [StringLength(10)]
        public string Clm_IsHospitalized { get; set; }

        public DateTime? Clm_HospitalStayFrom { get; set; }

        public DateTime? Clm_HospitalStayTo { get; set; }

        [StringLength(10)]
        public string Clm_CoverageCode { get; set; }

        [StringLength(100)]
        public string Clm_CoverageDescription { get; set; }

        [StringLength(200)]
        public string Clm_PhysicianDocName { get; set; }

        [StringLength(200)]
        public string Clm_PhysicianDocPath { get; set; }

        [StringLength(50)]
        public string ClmPatientProgress { get; set; }

        [StringLength(10)]
        public string ClmIsTotallyDisabled { get; set; }

        public DateTime? ClmResumeStartDate { get; set; }

        public DateTime? ClmPatientWorkedDate { get; set; }

        [StringLength(50)]
        public string ClmEstimatedTime { get; set; }

        [StringLength(10)]
        public string ClmIsTrailEmp { get; set; }

        public DateTime? ClmTrailDate { get; set; }

        [StringLength(10)]
        public string ClmIsReferredDoctor { get; set; }

        [StringLength(200)]
        public string ClmRefDoctorName { get; set; }

        [StringLength(100)]
        public string ClmRefCountry { get; set; }

        [StringLength(100)]
        public string ClmRefZone { get; set; }

        [StringLength(100)]
        public string ClmRefArea { get; set; }

        [StringLength(100)]
        public string ClmRefBlock { get; set; }

        [StringLength(100)]
        public string ClmRefRisk { get; set; }

        [StringLength(500)]
        public string ClmRefRemarks { get; set; }

        [StringLength(100)]
        public string ClmHouseNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_AdjusterNotes> Claim_AdjusterNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_ClaimantItemDetail> Claim_ClaimantItemDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Name> Claim_Name { get; set; }

        public virtual Mst_AddressArea Mst_AddressArea { get; set; }

        public virtual Mst_AddressArea Mst_AddressArea1 { get; set; }

        public virtual Mst_AddressArea Mst_AddressArea2 { get; set; }

        public virtual Mst_AddressBlock Mst_AddressBlock { get; set; }

        public virtual Mst_AddressBlock Mst_AddressBlock1 { get; set; }

        public virtual Mst_AddressBlock Mst_AddressBlock2 { get; set; }

        public virtual Mst_AddressRisk Mst_AddressRisk { get; set; }

        public virtual Mst_AddressRisk Mst_AddressRisk1 { get; set; }

        public virtual Mst_AddressRisk Mst_AddressRisk2 { get; set; }

        public virtual Mst_AddressZone Mst_AddressZone { get; set; }

        public virtual Mst_AddressZone Mst_AddressZone1 { get; set; }

        public virtual Mst_AddressZone Mst_AddressZone2 { get; set; }

        public virtual Mst_Country Mst_Country { get; set; }

        public virtual Mst_Country Mst_Country1 { get; set; }

        public virtual Mst_Country Mst_Country2 { get; set; }

        public virtual Mst_Proposal Mst_Proposal { get; set; }

        public virtual Mst_Proposal Mst_Proposal1 { get; set; }

        public virtual Mst_Usr Mst_Usr { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }

        public virtual PolicyInfo PolicyInfo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_PayOut> Claim_PayOut { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_ReinsuranceTransaction> Claim_ReinsuranceTransaction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_ReserveDetails> Claim_ReserveDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_ReserveHistory> Claim_ReserveHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_StatementofLoss> Claim_StatementofLoss { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClaimAddOnCoverage> ClaimAddOnCoverages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClaimDocument> ClaimDocuments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClaimStatu> ClaimStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaryNote> DiaryNotes { get; set; }
    }
}
