namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolicyInfo")]
    public partial class PolicyInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PolicyInfo()
        {
            Billings = new HashSet<Billing>();
            Claim_AdjusterNotes = new HashSet<Claim_AdjusterNotes>();
            Claim_Occurence = new HashSet<Claim_Occurence>();
            Claim_Occurence1 = new HashSet<Claim_Occurence>();
            Claim_ReinsuranceTransaction = new HashSet<Claim_ReinsuranceTransaction>();
            Cmn_Address = new HashSet<Cmn_Address>();
            Cmn_QuestionAnswer = new HashSet<Cmn_QuestionAnswer>();
            CoinsuranceDetails = new HashSet<CoinsuranceDetail>();
            CoverageDetails = new HashSet<CoverageDetail>();
            DiaryNotes = new HashSet<DiaryNote>();
            FundSchemeValues = new HashSet<FundSchemeValue>();
            PaymentInfoes = new HashSet<PaymentInfo>();
            PersonalInfoes = new HashSet<PersonalInfo>();
            PolicyCoverages = new HashSet<PolicyCoverage>();
            PolicyDocuments = new HashSet<PolicyDocument>();
            PolicyHolderInfoes = new HashSet<PolicyHolderInfo>();
            PolicyInvestmentApproaches = new HashSet<PolicyInvestmentApproach>();
            PolicyPooledInvestments = new HashSet<PolicyPooledInvestment>();
            PolicyRiskPreferences = new HashSet<PolicyRiskPreference>();
            Prem_RateNew = new HashSet<Prem_RateNew>();
            PremiumInfoes = new HashSet<PremiumInfo>();
            RenewalPolicies = new HashSet<RenewalPolicy>();
            SourceOfFunds = new HashSet<SourceOfFund>();
            Transaction_Details = new HashSet<Transaction_Details>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuoteNo { get; set; }

        public int? Pol_ClientID { get; set; }

        [StringLength(4)]
        public string Pol_ProposalCode { get; set; }

        [StringLength(4)]
        public string Pol_PolTermCode { get; set; }

        [StringLength(1)]
        public string Pol_PolTermType { get; set; }

        [StringLength(10)]
        public string Pol_Prefix { get; set; }

        [StringLength(3)]
        public string Pol_ProdCode { get; set; }

        [StringLength(25)]
        public string Pol_PolicyNumber { get; set; }

        public DateTime? Pol_EffectiveDate { get; set; }

        public DateTime? Pol_ExpiryDate { get; set; }

        [StringLength(4)]
        public string Pol_Insurance_Type { get; set; }

        [StringLength(1)]
        public string Pol_Insured_Type { get; set; }

        [StringLength(5)]
        public string Pol_PayPlanCode { get; set; }

        public decimal? Pol_TotalPremium { get; set; }

        [StringLength(2)]
        public string Pol_TransType { get; set; }

        public DateTime? Pol_TransDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pol_SplDis { get; set; }

        public DateTime? Pol_SysDate { get; set; }

        public bool? Pol_Pif { get; set; }

        public decimal? Pol_Arrear { get; set; }

        [StringLength(10)]
        public string Pol_PrevPrfx { get; set; }

        [StringLength(3)]
        public string Pol_PrevProdCd { get; set; }

        [StringLength(25)]
        public string Pol_PrevPolNo { get; set; }

        [StringLength(10)]
        public string Pol_AgentiD { get; set; }

        [StringLength(2)]
        public string Pol_Stat { get; set; }

        [StringLength(50)]
        public string Pol_PolNoRef { get; set; }

        public int? Pol_QuoteNoRef { get; set; }

        public bool Pol_IsActive { get; set; }

        [StringLength(500)]
        public string Review_Code { get; set; }

        [StringLength(4)]
        public string Currency_Type { get; set; }

        [StringLength(10)]
        public string Lead_Company { get; set; }

        public int? Credit_Rating { get; set; }

        [StringLength(4)]
        public string Pol_CustomerStatus { get; set; }

        [StringLength(4)]
        public string Pol_Class { get; set; }

        public decimal? Lead_Company_Percentage { get; set; }

        public DateTime? Review_Pending_Date { get; set; }

        [StringLength(2)]
        public string PoliticallySesnsitivePerson { get; set; }

        [StringLength(60)]
        public string CoApplicant { get; set; }

        public bool? Pep { get; set; }

        public int? Pol_GroupID { get; set; }

        public bool? Fronting { get; set; }

        [StringLength(50)]
        public string FrontingCompany { get; set; }

        public int? Commission { get; set; }

        [StringLength(50)]
        public string FAddressLine1 { get; set; }

        [StringLength(50)]
        public string FAddressLine2 { get; set; }

        [StringLength(50)]
        public string FCity { get; set; }

        [StringLength(50)]
        public string FState { get; set; }

        [StringLength(50)]
        public string FCountry { get; set; }

        [StringLength(500)]
        public string Pol_TransDetail { get; set; }

        [StringLength(10)]
        public string Producer_Name { get; set; }

        [StringLength(100)]
        public string Pol_TransTypeDetail { get; set; }

        [StringLength(3)]
        public string Producer_Type { get; set; }

        public int? Pol_TransNo { get; set; }

        public int? Pol_TransSeqNo { get; set; }

        [StringLength(10)]
        public string FZip { get; set; }

        [StringLength(10)]
        public string Pol_ApproveUserId { get; set; }

        [StringLength(1)]
        public string Pol_ApproveStatus { get; set; }

        [StringLength(500)]
        public string Pol_ApproveComments { get; set; }

        public DateTime? Pol_ApproveDate { get; set; }

        public bool? Pol_IsTobagoDiscount { get; set; }

        public int? Pol_InvoiceNo { get; set; }

        [StringLength(15)]
        public string Pol_LeadCompanyName { get; set; }

        public decimal? Pol_Proportion { get; set; }

        [StringLength(15)]
        public string Pol_CertificateNo { get; set; }

        public decimal? Pol_PolicyPremium { get; set; }

        [StringLength(2)]
        public string Risk_Type { get; set; }

        [StringLength(10)]
        public string Pol_GroupCompanyCode { get; set; }

        [StringLength(1)]
        public string Pol_FacCoverageType { get; set; }

        public decimal? Pol_FacAmount { get; set; }

        public int? Pol_FacTreatyId { get; set; }

        [StringLength(50)]
        public string Pol_FacTreatyName { get; set; }

        [StringLength(10)]
        public string branch_code { get; set; }

        [StringLength(40)]
        public string Pol_ProfitCenter { get; set; }

        public int? Pol_ProspectiveId { get; set; }

        [StringLength(1)]
        public string Pol_PaymentType { get; set; }

        [StringLength(50)]
        public string Pol_INSURPolicyno { get; set; }

        public bool? Pol_IsQuickQuote { get; set; }

        public bool? Pol_IsQuickQuoteAccepted { get; set; }

        [StringLength(10)]
        public string AdjustmentFrequency { get; set; }

        [StringLength(10)]
        public string PaymentFrequency { get; set; }

        public int? BrokerCommission { get; set; }

        public decimal? PolicyFees { get; set; }

        [StringLength(50)]
        public string CLLoanType { get; set; }

        [StringLength(50)]
        public string RefundOption { get; set; }

        [StringLength(10)]
        public string PremiumMode { get; set; }

        public decimal? BlendedPrimaryRate { get; set; }

        public decimal? BlendedSecondaryRate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Billing> Billings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_AdjusterNotes> Claim_AdjusterNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Occurence> Claim_Occurence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Occurence> Claim_Occurence1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_ReinsuranceTransaction> Claim_ReinsuranceTransaction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cmn_Address> Cmn_Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cmn_QuestionAnswer> Cmn_QuestionAnswer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoinsuranceDetail> CoinsuranceDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoverageDetail> CoverageDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaryNote> DiaryNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FundSchemeValue> FundSchemeValues { get; set; }

        public virtual Mst_Currency Mst_Currency { get; set; }

        public virtual Mst_CustomerStatus Mst_CustomerStatus { get; set; }

        public virtual Mst_ProducerCode Mst_ProducerCode { get; set; }

        public virtual MST_ProducerName MST_ProducerName { get; set; }

        public virtual Mst_Proposal Mst_Proposal { get; set; }

        public virtual Mst_ReInsurer Mst_ReInsurer { get; set; }

        public virtual Mst_TransType Mst_TransType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentInfo> PaymentInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalInfo> PersonalInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyCoverage> PolicyCoverages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyDocument> PolicyDocuments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyHolderInfo> PolicyHolderInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyInvestmentApproach> PolicyInvestmentApproaches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyPooledInvestment> PolicyPooledInvestments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyRiskPreference> PolicyRiskPreferences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prem_RateNew> Prem_RateNew { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PremiumInfo> PremiumInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RenewalPolicy> RenewalPolicies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SourceOfFund> SourceOfFunds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction_Details> Transaction_Details { get; set; }
    }
}
