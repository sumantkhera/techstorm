namespace DLL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class POCEntities : DbContext
    {
        public POCEntities()
            : base("name=POCEntities")
        {
        }

        public virtual DbSet<AddressTemp> AddressTemps { get; set; }
        public virtual DbSet<Audit_History> Audit_History { get; set; }
        public virtual DbSet<Base_CommonNew> Base_CommonNew { get; set; }
        public virtual DbSet<BaseMortgagee> BaseMortgagees { get; set; }
        public virtual DbSet<BaseShortRate> BaseShortRates { get; set; }
        public virtual DbSet<BaseSingleRate> BaseSingleRates { get; set; }
        public virtual DbSet<BatchChequeDetail> BatchChequeDetails { get; set; }
        public virtual DbSet<BatchChequeDetailsLog> BatchChequeDetailsLogs { get; set; }
        public virtual DbSet<BatchSummary> BatchSummaries { get; set; }
        public virtual DbSet<Billing> Billings { get; set; }
        public virtual DbSet<Claim_AdjusterNotes> Claim_AdjusterNotes { get; set; }
        public virtual DbSet<Claim_ClaimantItemDetail> Claim_ClaimantItemDetail { get; set; }
        public virtual DbSet<Claim_Comments> Claim_Comments { get; set; }
        public virtual DbSet<Claim_ItemsCoveredType> Claim_ItemsCoveredType { get; set; }
        public virtual DbSet<Claim_Name> Claim_Name { get; set; }
        public virtual DbSet<Claim_Occurence> Claim_Occurence { get; set; }
        public virtual DbSet<Claim_PayOut> Claim_PayOut { get; set; }
        public virtual DbSet<Claim_PayOutHistory> Claim_PayOutHistory { get; set; }
        public virtual DbSet<Claim_ReinsuranceTransaction> Claim_ReinsuranceTransaction { get; set; }
        public virtual DbSet<Claim_ReserveDetails> Claim_ReserveDetails { get; set; }
        public virtual DbSet<Claim_ReserveHistory> Claim_ReserveHistory { get; set; }
        public virtual DbSet<Claim_StatementofLoss> Claim_StatementofLoss { get; set; }
        public virtual DbSet<ClaimAddOnCoverage> ClaimAddOnCoverages { get; set; }
        public virtual DbSet<ClaimDocument> ClaimDocuments { get; set; }
        public virtual DbSet<ClaimLimitationDetail> ClaimLimitationDetails { get; set; }
        public virtual DbSet<ClaimMortgage> ClaimMortgages { get; set; }
        public virtual DbSet<ClaimStatu> ClaimStatus { get; set; }
        public virtual DbSet<ClientDetail> ClientDetails { get; set; }
        public virtual DbSet<Cmn_Address> Cmn_Address { get; set; }
        public virtual DbSet<Cmn_QuestionAnswer> Cmn_QuestionAnswer { get; set; }
        public virtual DbSet<CoinsuranceDetail> CoinsuranceDetails { get; set; }
        public virtual DbSet<CompanyToSubCompany> CompanyToSubCompanies { get; set; }
        public virtual DbSet<CoverageDetail> CoverageDetails { get; set; }
        public virtual DbSet<DiaryNote> DiaryNotes { get; set; }
        public virtual DbSet<DiseaseDetail> DiseaseDetails { get; set; }
        public virtual DbSet<DiseaseDetailsTemp> DiseaseDetailsTemps { get; set; }
        public virtual DbSet<EarnedPremiumSummary> EarnedPremiumSummaries { get; set; }
        public virtual DbSet<EarnedPremiumTranscation> EarnedPremiumTranscations { get; set; }
        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<ExcelInformation> ExcelInformations { get; set; }
        public virtual DbSet<ExceptionLogger> ExceptionLoggers { get; set; }
        public virtual DbSet<Fact_Info> Fact_Info { get; set; }
        public virtual DbSet<FundSchemeValue> FundSchemeValues { get; set; }
        public virtual DbSet<HealthInfo> HealthInfoes { get; set; }
        public virtual DbSet<HealthInfoTemp> HealthInfoTemps { get; set; }
        public virtual DbSet<MasterCoverageSumInsured> MasterCoverageSumInsureds { get; set; }
        public virtual DbSet<MasterDisease> MasterDiseases { get; set; }
        public virtual DbSet<MasterDocument> MasterDocuments { get; set; }
        public virtual DbSet<MasterFrequency> MasterFrequencies { get; set; }
        public virtual DbSet<MemberAddonCoverage> MemberAddonCoverages { get; set; }
        public virtual DbSet<MemberAddonCoverageTemp> MemberAddonCoverageTemps { get; set; }
        public virtual DbSet<MemberCoverageInfo> MemberCoverageInfoes { get; set; }
        public virtual DbSet<MemberCoverageInfoTemp> MemberCoverageInfoTemps { get; set; }
        public virtual DbSet<MemberDocument> MemberDocuments { get; set; }
        public virtual DbSet<MemberLoan> MemberLoans { get; set; }
        public virtual DbSet<MemberLoanTemp> MemberLoanTemps { get; set; }
        public virtual DbSet<Mnu_Authority> Mnu_Authority { get; set; }
        public virtual DbSet<MortgageFinancialDetail> MortgageFinancialDetails { get; set; }
        public virtual DbSet<MortgageIncomeExpence> MortgageIncomeExpences { get; set; }
        public virtual DbSet<MortgageLifePolicy> MortgageLifePolicies { get; set; }
        public virtual DbSet<MortgagePropertyDetail> MortgagePropertyDetails { get; set; }
        public virtual DbSet<Mst_AddOnCoverage> Mst_AddOnCoverage { get; set; }
        public virtual DbSet<Mst_AddressArea> Mst_AddressArea { get; set; }
        public virtual DbSet<Mst_AddressBlock> Mst_AddressBlock { get; set; }
        public virtual DbSet<Mst_AddressRisk> Mst_AddressRisk { get; set; }
        public virtual DbSet<Mst_AddressZone> Mst_AddressZone { get; set; }
        public virtual DbSet<Mst_Branch> Mst_Branch { get; set; }
        public virtual DbSet<Mst_BrokerCommissions> Mst_BrokerCommissions { get; set; }
        public virtual DbSet<Mst_Claim_Range> Mst_Claim_Range { get; set; }
        public virtual DbSet<Mst_ClaimAddOnCoverage> Mst_ClaimAddOnCoverage { get; set; }
        public virtual DbSet<Mst_ClaimDocument> Mst_ClaimDocument { get; set; }
        public virtual DbSet<Mst_ClaimLossCause> Mst_ClaimLossCause { get; set; }
        public virtual DbSet<Mst_ClaimStatus> Mst_ClaimStatus { get; set; }
        public virtual DbSet<Mst_Country> Mst_Country { get; set; }
        public virtual DbSet<Mst_Coverage> Mst_Coverage { get; set; }
        public virtual DbSet<Mst_CreditRating> Mst_CreditRating { get; set; }
        public virtual DbSet<Mst_Currency> Mst_Currency { get; set; }
        public virtual DbSet<Mst_CustomerStatus> Mst_CustomerStatus { get; set; }
        public virtual DbSet<mst_DocumentType> mst_DocumentType { get; set; }
        public virtual DbSet<mst_EndorsementType> mst_EndorsementType { get; set; }
        public virtual DbSet<Mst_Expense> Mst_Expense { get; set; }
        public virtual DbSet<Mst_Grp> Mst_Grp { get; set; }
        public virtual DbSet<Mst_InvestmentApproach> Mst_InvestmentApproach { get; set; }
        public virtual DbSet<Mst_LOB> Mst_LOB { get; set; }
        public virtual DbSet<Mst_LOBCountry> Mst_LOBCountry { get; set; }
        public virtual DbSet<Mst_MasterGrp> Mst_MasterGrp { get; set; }
        public virtual DbSet<Mst_Mnu> Mst_Mnu { get; set; }
        public virtual DbSet<Mst_Nationality> Mst_Nationality { get; set; }
        public virtual DbSet<Mst_NavSetup> Mst_NavSetup { get; set; }
        public virtual DbSet<Mst_Occupation> Mst_Occupation { get; set; }
        public virtual DbSet<Mst_Payee> Mst_Payee { get; set; }
        public virtual DbSet<Mst_PolicyClass> Mst_PolicyClass { get; set; }
        public virtual DbSet<Mst_PolicyTerm> Mst_PolicyTerm { get; set; }
        public virtual DbSet<Mst_ProducerCode> Mst_ProducerCode { get; set; }
        public virtual DbSet<MST_ProducerName> MST_ProducerName { get; set; }
        public virtual DbSet<Mst_Proposal> Mst_Proposal { get; set; }
        public virtual DbSet<Mst_Question> Mst_Question { get; set; }
        public virtual DbSet<Mst_Range> Mst_Range { get; set; }
        public virtual DbSet<Mst_Receipt_Range> Mst_Receipt_Range { get; set; }
        public virtual DbSet<Mst_ReInsurer> Mst_ReInsurer { get; set; }
        public virtual DbSet<Mst_Relationship> Mst_Relationship { get; set; }
        public virtual DbSet<Mst_ReviewedDocument> Mst_ReviewedDocument { get; set; }
        public virtual DbSet<Mst_RiskPreference> Mst_RiskPreference { get; set; }
        public virtual DbSet<Mst_Salutation> Mst_Salutation { get; set; }
        public virtual DbSet<Mst_SystemVariable> Mst_SystemVariable { get; set; }
        public virtual DbSet<Mst_Tabs> Mst_Tabs { get; set; }
        public virtual DbSet<Mst_TradeGroup> Mst_TradeGroup { get; set; }
        public virtual DbSet<Mst_TransType> Mst_TransType { get; set; }
        public virtual DbSet<Mst_TrinreDetail> Mst_TrinreDetail { get; set; }
        public virtual DbSet<Mst_Usr> Mst_Usr { get; set; }
        public virtual DbSet<Mst_WorkShop> Mst_WorkShop { get; set; }
        public virtual DbSet<MstClaimLimitation> MstClaimLimitations { get; set; }
        public virtual DbSet<NavPayment> NavPayments { get; set; }
        public virtual DbSet<PaymentInfo> PaymentInfoes { get; set; }
        public virtual DbSet<PaymentInfoLog> PaymentInfoLogs { get; set; }
        public virtual DbSet<PersonalInfo> PersonalInfoes { get; set; }
        public virtual DbSet<PersonalInfoTemp> PersonalInfoTemps { get; set; }
        public virtual DbSet<Personnel_Identity> Personnel_Identity { get; set; }
        public virtual DbSet<PersonnelIdentityTemp> PersonnelIdentityTemps { get; set; }
        public virtual DbSet<PolicyApproveDetail> PolicyApproveDetails { get; set; }
        public virtual DbSet<PolicyCoverage> PolicyCoverages { get; set; }
        public virtual DbSet<PolicyCoverTemp> PolicyCoverTemps { get; set; }
        public virtual DbSet<PolicyDocument> PolicyDocuments { get; set; }
        public virtual DbSet<PolicyHolderInfo> PolicyHolderInfoes { get; set; }
        public virtual DbSet<PolicyInfo> PolicyInfoes { get; set; }
        public virtual DbSet<PolicyInfoTemp> PolicyInfoTemps { get; set; }
        public virtual DbSet<PolicyInvestmentApproach> PolicyInvestmentApproaches { get; set; }
        public virtual DbSet<PolicyPooledInvestment> PolicyPooledInvestments { get; set; }
        public virtual DbSet<PolicyRiskPreference> PolicyRiskPreferences { get; set; }
        public virtual DbSet<Prem_RateNew> Prem_RateNew { get; set; }
        public virtual DbSet<PremiumInfo> PremiumInfoes { get; set; }
        public virtual DbSet<ReinsuranceTransaction> ReinsuranceTransactions { get; set; }
        public virtual DbSet<ReinsuranceTransactionHistory> ReinsuranceTransactionHistories { get; set; }
        public virtual DbSet<RemittanceAdvice> RemittanceAdvices { get; set; }
        public virtual DbSet<RenewalPolicy> RenewalPolicies { get; set; }
        public virtual DbSet<SourceOfFund> SourceOfFunds { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Transaction_Details> Transaction_Details { get; set; }
        public virtual DbSet<VoucherDetail> VoucherDetails { get; set; }
        public virtual DbSet<Mst_AnnuityBenefitPlans> Mst_AnnuityBenefitPlans { get; set; }
        public virtual DbSet<PensionSourceOfFundsTemp> PensionSourceOfFundsTemps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressTemp>()
                .HasMany(e => e.PersonalInfoTemps)
                .WithOptional(e => e.AddressTemp)
                .HasForeignKey(e => e.PostalAddressId);

            modelBuilder.Entity<AddressTemp>()
                .HasMany(e => e.PersonalInfoTemps1)
                .WithOptional(e => e.AddressTemp1)
                .HasForeignKey(e => e.CorsAddressId);

            modelBuilder.Entity<Audit_History>()
                .Property(e => e.ModeOfOperation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Base_CommonNew>()
                .Property(e => e.SD_Factor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Base_CommonNew>()
                .Property(e => e.SD_Fact_Amount)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Base_CommonNew>()
                .Property(e => e.SD_Fact_Division)
                .HasPrecision(10, 2);

            modelBuilder.Entity<BaseMortgagee>()
                .Property(e => e.RateType)
                .IsUnicode(false);

            modelBuilder.Entity<BaseMortgagee>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Billing>()
                .Property(e => e.Pay_Fee1)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Billing>()
                .Property(e => e.Pay_Fee2)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Billing>()
                .Property(e => e.CommissionPercent)
                .HasPrecision(15, 2);

            modelBuilder.Entity<Billing>()
                .HasMany(e => e.PaymentInfoes)
                .WithOptional(e => e.Billing)
                .HasForeignKey(e => e.Pymnt_BillId);

            modelBuilder.Entity<Claim_ClaimantItemDetail>()
                .HasMany(e => e.Claim_PayOut)
                .WithOptional(e => e.Claim_ClaimantItemDetail)
                .HasForeignKey(e => e.Clm_ItemCovered);

            modelBuilder.Entity<Claim_Occurence>()
                .Property(e => e.Clm_InsurClaimNo)
                .IsUnicode(false);

            modelBuilder.Entity<Claim_Occurence>()
                .HasMany(e => e.Claim_AdjusterNotes)
                .WithRequired(e => e.Claim_Occurence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Claim_Occurence>()
                .HasMany(e => e.Claim_ClaimantItemDetail)
                .WithRequired(e => e.Claim_Occurence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Claim_Occurence>()
                .HasMany(e => e.Claim_Name)
                .WithRequired(e => e.Claim_Occurence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Claim_Occurence>()
                .HasMany(e => e.Claim_PayOut)
                .WithRequired(e => e.Claim_Occurence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Claim_Occurence>()
                .HasMany(e => e.Claim_ReinsuranceTransaction)
                .WithRequired(e => e.Claim_Occurence)
                .HasForeignKey(e => e.RT_ClaimNo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Claim_Occurence>()
                .HasMany(e => e.Claim_ReserveDetails)
                .WithRequired(e => e.Claim_Occurence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Claim_Occurence>()
                .HasMany(e => e.Claim_ReserveHistory)
                .WithRequired(e => e.Claim_Occurence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Claim_Occurence>()
                .HasMany(e => e.Claim_StatementofLoss)
                .WithRequired(e => e.Claim_Occurence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Claim_Occurence>()
                .HasMany(e => e.ClaimAddOnCoverages)
                .WithRequired(e => e.Claim_Occurence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Claim_Occurence>()
                .HasMany(e => e.ClaimDocuments)
                .WithRequired(e => e.Claim_Occurence)
                .HasForeignKey(e => e.Doc_ClaimNo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Claim_Occurence>()
                .HasMany(e => e.ClaimStatus)
                .WithRequired(e => e.Claim_Occurence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Claim_Occurence>()
                .HasMany(e => e.DiaryNotes)
                .WithOptional(e => e.Claim_Occurence)
                .HasForeignKey(e => e.ClaimNo);

            modelBuilder.Entity<Claim_ReinsuranceTransaction>()
                .Property(e => e.RT_LimitPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Claim_ReinsuranceTransaction>()
                .Property(e => e.RT_CATPerilPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Claim_ReinsuranceTransaction>()
                .Property(e => e.RT_NonCATPerilPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Claim_ReinsuranceTransaction>()
                .Property(e => e.RT_SumInsuredPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Claim_ReinsuranceTransaction>()
                .Property(e => e.RT_CATPerilCommPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Claim_ReinsuranceTransaction>()
                .Property(e => e.RT_NonCATPerilCommPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Claim_ReserveDetails>()
                .Property(e => e.Res_Status)
                .IsUnicode(false);

            modelBuilder.Entity<Claim_ReserveDetails>()
                .HasMany(e => e.Claim_PayOut)
                .WithOptional(e => e.Claim_ReserveDetails)
                .HasForeignKey(e => e.Clm_ReserveLineId);

            modelBuilder.Entity<Claim_ReserveDetails>()
                .HasMany(e => e.Claim_ReserveHistory)
                .WithOptional(e => e.Claim_ReserveDetails)
                .HasForeignKey(e => e.Res_ReserveId);

            modelBuilder.Entity<ClientDetail>()
                .Property(e => e.Clt_ApproverStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Cmn_Address>()
                .HasMany(e => e.ClientDetails)
                .WithOptional(e => e.Cmn_Address)
                .HasForeignKey(e => e.Clt_PostalAddressId);

            modelBuilder.Entity<Cmn_Address>()
                .HasMany(e => e.ClientDetails1)
                .WithOptional(e => e.Cmn_Address1)
                .HasForeignKey(e => e.Clt_CorsAddressId);

            modelBuilder.Entity<Cmn_Address>()
                .HasMany(e => e.ClientDetails2)
                .WithOptional(e => e.Cmn_Address2)
                .HasForeignKey(e => e.Clt_EmpAddressId);

            modelBuilder.Entity<Cmn_Address>()
                .HasMany(e => e.Employers)
                .WithOptional(e => e.Cmn_Address)
                .HasForeignKey(e => e.Emp_AddressId);

            modelBuilder.Entity<Cmn_Address>()
                .HasMany(e => e.PersonalInfoes)
                .WithOptional(e => e.Cmn_Address)
                .HasForeignKey(e => e.PostalAddressId);

            modelBuilder.Entity<Cmn_Address>()
                .HasMany(e => e.PersonalInfoes1)
                .WithOptional(e => e.Cmn_Address1)
                .HasForeignKey(e => e.CorsAddressId);

            modelBuilder.Entity<Cmn_Address>()
                .HasMany(e => e.PersonalInfoes2)
                .WithOptional(e => e.Cmn_Address2)
                .HasForeignKey(e => e.PostalAddressId);

            modelBuilder.Entity<Cmn_Address>()
                .HasMany(e => e.PersonalInfoes3)
                .WithOptional(e => e.Cmn_Address3)
                .HasForeignKey(e => e.CorsAddressId);

            modelBuilder.Entity<CoverageDetail>()
                .Property(e => e.AnnualContri)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ExcelInformation>()
                .HasMany(e => e.PersonalInfoTemps)
                .WithOptional(e => e.ExcelInformation)
                .HasForeignKey(e => e.ExcelId);

            modelBuilder.Entity<ExcelInformation>()
                .HasMany(e => e.PolicyInfoTemps)
                .WithRequired(e => e.ExcelInformation)
                .HasForeignKey(e => e.ExcelId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExceptionLogger>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<ExceptionLogger>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<ExceptionLogger>()
                .Property(e => e.ExceptionMessage)
                .IsUnicode(false);

            modelBuilder.Entity<ExceptionLogger>()
                .Property(e => e.ControllerName)
                .IsUnicode(false);

            modelBuilder.Entity<ExceptionLogger>()
                .Property(e => e.ExceptionStackTrace)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.ApartmentNo)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.SocialSecurityNo)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.TaxPayerID)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.County)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.Emp_Designation)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.Manager)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.MG_Address1)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.MG_Address2)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.MG_State)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.MG_County)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.MG_Country)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.MG_EmployerID)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.CompanyRegNo)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.ProposerType)
                .IsUnicode(false);

            modelBuilder.Entity<Fact_Info>()
                .Property(e => e.PolicyType)
                .IsUnicode(false);

            modelBuilder.Entity<MasterCoverageSumInsured>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<MasterCoverageSumInsured>()
                .Property(e => e.LastModifyBy)
                .IsUnicode(false);

            modelBuilder.Entity<MasterDisease>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<MasterDisease>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MasterDocument>()
                .Property(e => e.DocumentName)
                .IsUnicode(false);

            modelBuilder.Entity<MasterDocument>()
                .Property(e => e.Coverage)
                .IsUnicode(false);

            modelBuilder.Entity<MasterDocument>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<MemberAddonCoverageTemp>()
                .Property(e => e.CalcPremium)
                .HasPrecision(15, 2);

            modelBuilder.Entity<MemberCoverageInfoTemp>()
                .Property(e => e.AnnualSalary)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MemberCoverageInfoTemp>()
                .Property(e => e.LoanAppliedAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MemberCoverageInfoTemp>()
                .Property(e => e.ExistingLoanBalance)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MemberCoverageInfoTemp>()
                .Property(e => e.MaxDeathBenefit)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MemberCoverageInfoTemp>()
                .Property(e => e.Premium)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MemberCoverageInfoTemp>()
                .Property(e => e.TotalLoanAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MemberCoverageInfoTemp>()
                .Property(e => e.Coverage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MemberLoan>()
                .Property(e => e.ClientId)
                .IsUnicode(false);

            modelBuilder.Entity<MemberLoanTemp>()
                .Property(e => e.ClientId)
                .IsUnicode(false);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.GrossSalary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.Allowance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.RentIncome)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.OtherIncome)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.IncomeTax)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.NationalInsurance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.WidowsOrphan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.CreditUnion)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.LifeHeathContribution)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.InsurancePremium)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.BankLoans)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.OtherLoans)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.HirePurchase)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.Rent)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.LivingExpence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.Entertainment)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.TotalIncome)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.TotalExpence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.TotalLiabilities)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageFinancialDetail>()
                .Property(e => e.TotalAssests)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.GrossSalary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.Allowance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.RentIncome)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.OtherIncome)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.IncomeTax)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.NationalInsurance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.WidowsOrphan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.CreditUnion)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.LifeHeathContribution)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.InsurancePremium)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.BankLoans)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.OtherLoans)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.HirePurchase)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.Rent)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.LivingExpence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageIncomeExpence>()
                .Property(e => e.Entertainment)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageLifePolicy>()
                .Property(e => e.FaceValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgageLifePolicy>()
                .Property(e => e.SurrenderValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgagePropertyDetail>()
                .Property(e => e.ProposedPurchasePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgagePropertyDetail>()
                .Property(e => e.TotalCostBuilding)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgagePropertyDetail>()
                .Property(e => e.CashPaid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgagePropertyDetail>()
                .Property(e => e.TotalLotCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgagePropertyDetail>()
                .Property(e => e.CostOfLotPsf)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgagePropertyDetail>()
                .Property(e => e.EstimatedCostBuildingPsf)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgagePropertyDetail>()
                .Property(e => e.TotalEstimatedCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgagePropertyDetail>()
                .Property(e => e.BuildingPlanNo)
                .IsUnicode(false);

            modelBuilder.Entity<MortgagePropertyDetail>()
                .Property(e => e.EstimatedMOnthlyRental)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MortgagePropertyDetail>()
                .Property(e => e.EstimatedInsuredValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Mst_AddressArea>()
                .HasMany(e => e.Claim_Name)
                .WithOptional(e => e.Mst_AddressArea)
                .HasForeignKey(e => e.Clm_AreaId);

            modelBuilder.Entity<Mst_AddressArea>()
                .HasMany(e => e.Claim_Occurence)
                .WithOptional(e => e.Mst_AddressArea)
                .HasForeignKey(e => e.Clm_AreaId);

            modelBuilder.Entity<Mst_AddressArea>()
                .HasMany(e => e.Claim_Occurence1)
                .WithOptional(e => e.Mst_AddressArea1)
                .HasForeignKey(e => e.Clm_AreaIdPersonBlamed);

            modelBuilder.Entity<Mst_AddressArea>()
                .HasMany(e => e.Claim_Occurence2)
                .WithOptional(e => e.Mst_AddressArea2)
                .HasForeignKey(e => e.Clm_LossAreaId);

            modelBuilder.Entity<Mst_AddressArea>()
                .HasMany(e => e.Cmn_Address)
                .WithOptional(e => e.Mst_AddressArea)
                .HasForeignKey(e => e.Ads_AreaId);

            modelBuilder.Entity<Mst_AddressArea>()
                .HasMany(e => e.Mst_WorkShop)
                .WithOptional(e => e.Mst_AddressArea)
                .HasForeignKey(e => e.Wrk_AreaId);

            modelBuilder.Entity<Mst_AddressBlock>()
                .HasMany(e => e.Claim_Name)
                .WithOptional(e => e.Mst_AddressBlock)
                .HasForeignKey(e => e.Clm_BlockId);

            modelBuilder.Entity<Mst_AddressBlock>()
                .HasMany(e => e.Claim_Occurence)
                .WithOptional(e => e.Mst_AddressBlock)
                .HasForeignKey(e => e.Clm_BlockId);

            modelBuilder.Entity<Mst_AddressBlock>()
                .HasMany(e => e.Claim_Occurence1)
                .WithOptional(e => e.Mst_AddressBlock1)
                .HasForeignKey(e => e.Clm_BlockIdPersonBlamed);

            modelBuilder.Entity<Mst_AddressBlock>()
                .HasMany(e => e.Claim_Occurence2)
                .WithOptional(e => e.Mst_AddressBlock2)
                .HasForeignKey(e => e.Clm_LossBlockId);

            modelBuilder.Entity<Mst_AddressBlock>()
                .HasMany(e => e.Cmn_Address)
                .WithOptional(e => e.Mst_AddressBlock)
                .HasForeignKey(e => e.Ads_BlockId);

            modelBuilder.Entity<Mst_AddressBlock>()
                .HasMany(e => e.Mst_WorkShop)
                .WithOptional(e => e.Mst_AddressBlock)
                .HasForeignKey(e => e.Wrk_BlockId);

            modelBuilder.Entity<Mst_AddressRisk>()
                .HasMany(e => e.Claim_Name)
                .WithOptional(e => e.Mst_AddressRisk)
                .HasForeignKey(e => e.Clm_RiskId);

            modelBuilder.Entity<Mst_AddressRisk>()
                .HasMany(e => e.Claim_Occurence)
                .WithOptional(e => e.Mst_AddressRisk)
                .HasForeignKey(e => e.Clm_RiskId);

            modelBuilder.Entity<Mst_AddressRisk>()
                .HasMany(e => e.Claim_Occurence1)
                .WithOptional(e => e.Mst_AddressRisk1)
                .HasForeignKey(e => e.Clm_RiskIdPersonBlamed);

            modelBuilder.Entity<Mst_AddressRisk>()
                .HasMany(e => e.Claim_Occurence2)
                .WithOptional(e => e.Mst_AddressRisk2)
                .HasForeignKey(e => e.Clm_LossRiskId);

            modelBuilder.Entity<Mst_AddressRisk>()
                .HasMany(e => e.Cmn_Address)
                .WithOptional(e => e.Mst_AddressRisk)
                .HasForeignKey(e => e.Ads_RiskId);

            modelBuilder.Entity<Mst_AddressRisk>()
                .HasMany(e => e.Mst_WorkShop)
                .WithOptional(e => e.Mst_AddressRisk)
                .HasForeignKey(e => e.Wrk_RiskId);

            modelBuilder.Entity<Mst_AddressZone>()
                .HasMany(e => e.Claim_Name)
                .WithOptional(e => e.Mst_AddressZone)
                .HasForeignKey(e => e.Clm_ZoneId);

            modelBuilder.Entity<Mst_AddressZone>()
                .HasMany(e => e.Claim_Occurence)
                .WithOptional(e => e.Mst_AddressZone)
                .HasForeignKey(e => e.Clm_ZoneId);

            modelBuilder.Entity<Mst_AddressZone>()
                .HasMany(e => e.Claim_Occurence1)
                .WithOptional(e => e.Mst_AddressZone1)
                .HasForeignKey(e => e.Clm_ZoneIdPersonBlamed);

            modelBuilder.Entity<Mst_AddressZone>()
                .HasMany(e => e.Claim_Occurence2)
                .WithOptional(e => e.Mst_AddressZone2)
                .HasForeignKey(e => e.Clm_LossZoneId);

            modelBuilder.Entity<Mst_AddressZone>()
                .HasMany(e => e.Cmn_Address)
                .WithOptional(e => e.Mst_AddressZone)
                .HasForeignKey(e => e.Ads_ZoneId);

            modelBuilder.Entity<Mst_AddressZone>()
                .HasMany(e => e.Mst_WorkShop)
                .WithOptional(e => e.Mst_AddressZone)
                .HasForeignKey(e => e.Wrk_ZoneId);

            modelBuilder.Entity<Mst_ClaimDocument>()
                .HasMany(e => e.ClaimDocuments)
                .WithOptional(e => e.Mst_ClaimDocument)
                .HasForeignKey(e => e.Doc_CodeId);

            modelBuilder.Entity<Mst_ClaimStatus>()
                .HasMany(e => e.ClaimStatus)
                .WithOptional(e => e.Mst_ClaimStatus)
                .HasForeignKey(e => e.Clm_StatusCode);

            modelBuilder.Entity<Mst_Country>()
                .HasMany(e => e.Claim_Name)
                .WithOptional(e => e.Mst_Country)
                .HasForeignKey(e => e.Clm_ClmntCountry);

            modelBuilder.Entity<Mst_Country>()
                .HasMany(e => e.Claim_Name1)
                .WithOptional(e => e.Mst_Country1)
                .HasForeignKey(e => e.Clm_LicenseCountry);

            modelBuilder.Entity<Mst_Country>()
                .HasMany(e => e.Claim_Name2)
                .WithOptional(e => e.Mst_Country2)
                .HasForeignKey(e => e.Clm_SecondLicenseCountry);

            modelBuilder.Entity<Mst_Country>()
                .HasMany(e => e.Claim_Occurence)
                .WithOptional(e => e.Mst_Country)
                .HasForeignKey(e => e.Clm_AcdntCountry);

            modelBuilder.Entity<Mst_Country>()
                .HasMany(e => e.Claim_Occurence1)
                .WithOptional(e => e.Mst_Country1)
                .HasForeignKey(e => e.Clm_CountryPersonBlamed);

            modelBuilder.Entity<Mst_Country>()
                .HasMany(e => e.Claim_Occurence2)
                .WithOptional(e => e.Mst_Country2)
                .HasForeignKey(e => e.Clm_LossCountryId);

            modelBuilder.Entity<Mst_Country>()
                .HasMany(e => e.ClientDetails)
                .WithOptional(e => e.Mst_Country)
                .HasForeignKey(e => e.Clt_FirstCountry);

            modelBuilder.Entity<Mst_Country>()
                .HasMany(e => e.ClientDetails1)
                .WithOptional(e => e.Mst_Country1)
                .HasForeignKey(e => e.Clt_SecondCountry);

            modelBuilder.Entity<Mst_Country>()
                .HasMany(e => e.Cmn_Address)
                .WithOptional(e => e.Mst_Country)
                .HasForeignKey(e => e.Ads_CountryId);

            modelBuilder.Entity<Mst_Country>()
                .HasMany(e => e.Mst_AddressZone)
                .WithOptional(e => e.Mst_Country)
                .HasForeignKey(e => e.country_code);

            modelBuilder.Entity<Mst_Country>()
                .HasMany(e => e.Personnel_Identity)
                .WithOptional(e => e.Mst_Country)
                .HasForeignKey(e => e.Idt_Country);

            modelBuilder.Entity<Mst_Currency>()
                .Property(e => e.current_rate)
                .HasPrecision(9, 4);

            modelBuilder.Entity<Mst_Currency>()
                .HasMany(e => e.PolicyInfoes)
                .WithOptional(e => e.Mst_Currency)
                .HasForeignKey(e => e.Currency_Type);

            modelBuilder.Entity<Mst_CustomerStatus>()
                .HasMany(e => e.PolicyInfoes)
                .WithOptional(e => e.Mst_CustomerStatus)
                .HasForeignKey(e => e.Pol_CustomerStatus);

            modelBuilder.Entity<mst_DocumentType>()
                .HasMany(e => e.Claim_Name)
                .WithOptional(e => e.mst_DocumentType)
                .HasForeignKey(e => e.Clm_LicenseType);

            modelBuilder.Entity<mst_DocumentType>()
                .HasMany(e => e.Claim_Name1)
                .WithOptional(e => e.mst_DocumentType1)
                .HasForeignKey(e => e.Clm_SecondLicenseType);

            modelBuilder.Entity<mst_DocumentType>()
                .HasMany(e => e.ClientDetails)
                .WithOptional(e => e.mst_DocumentType)
                .HasForeignKey(e => e.Clt_FirstLic_Type);

            modelBuilder.Entity<mst_DocumentType>()
                .HasMany(e => e.ClientDetails1)
                .WithOptional(e => e.mst_DocumentType1)
                .HasForeignKey(e => e.Clt_SecondLic_Type);

            modelBuilder.Entity<mst_DocumentType>()
                .HasMany(e => e.Personnel_Identity)
                .WithOptional(e => e.mst_DocumentType)
                .HasForeignKey(e => e.Pif_Lic_Type);

            modelBuilder.Entity<mst_DocumentType>()
                .HasMany(e => e.PolicyDocuments)
                .WithOptional(e => e.mst_DocumentType)
                .HasForeignKey(e => e.Pdo_Doc_TypeId);

            modelBuilder.Entity<Mst_Grp>()
                .Property(e => e.Grp_CommPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Mst_InvestmentApproach>()
                .HasMany(e => e.PolicyPooledInvestments)
                .WithOptional(e => e.Mst_InvestmentApproach)
                .HasForeignKey(e => e.PIFId);

            modelBuilder.Entity<Mst_LOB>()
                .HasMany(e => e.Mst_Proposal)
                .WithOptional(e => e.Mst_LOB)
                .HasForeignKey(e => e.Prp_LOB);

            modelBuilder.Entity<Mst_LOB>()
                .HasMany(e => e.Mst_LOBCountry)
                .WithRequired(e => e.Mst_LOB)
                .HasForeignKey(e => e.Country_LOB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_LOB>()
                .HasMany(e => e.Mst_Tabs)
                .WithOptional(e => e.Mst_LOB)
                .HasForeignKey(e => e.Tab_Prp_LOB);

            modelBuilder.Entity<Mst_Nationality>()
                .HasMany(e => e.ClientDetails)
                .WithOptional(e => e.Mst_Nationality)
                .HasForeignKey(e => e.Clt_NationalityId);

            modelBuilder.Entity<Mst_Nationality>()
                .HasMany(e => e.ClientDetails1)
                .WithOptional(e => e.Mst_Nationality1)
                .HasForeignKey(e => e.Clt_AppNationalityId);

            modelBuilder.Entity<Mst_Nationality>()
                .HasMany(e => e.ClientDetails2)
                .WithOptional(e => e.Mst_Nationality2)
                .HasForeignKey(e => e.Clt_CountryOfBirth);

            modelBuilder.Entity<Mst_Nationality>()
                .HasMany(e => e.ClientDetails3)
                .WithOptional(e => e.Mst_Nationality3)
                .HasForeignKey(e => e.Clt_AppCountryOfBirth);

            modelBuilder.Entity<Mst_Nationality>()
                .HasMany(e => e.PersonalInfoes)
                .WithOptional(e => e.Mst_Nationality)
                .HasForeignKey(e => e.NationalityId);

            modelBuilder.Entity<Mst_Nationality>()
                .HasMany(e => e.PersonalInfoes1)
                .WithOptional(e => e.Mst_Nationality1)
                .HasForeignKey(e => e.CountryOfBirth);

            modelBuilder.Entity<Mst_Nationality>()
                .HasMany(e => e.PolicyHolderInfoes)
                .WithOptional(e => e.Mst_Nationality)
                .HasForeignKey(e => e.NationalityId);

            modelBuilder.Entity<Mst_Nationality>()
                .HasMany(e => e.PolicyHolderInfoes1)
                .WithOptional(e => e.Mst_Nationality1)
                .HasForeignKey(e => e.CountryOfBirth);

            modelBuilder.Entity<Mst_PolicyClass>()
                .Property(e => e.gov_tax)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Mst_PolicyTerm>()
                .Property(e => e.Ter_Fact)
                .HasPrecision(5, 4);

            modelBuilder.Entity<Mst_ProducerCode>()
                .HasMany(e => e.EarnedPremiumTranscations)
                .WithOptional(e => e.Mst_ProducerCode)
                .HasForeignKey(e => e.Producer_Type);

            modelBuilder.Entity<Mst_ProducerCode>()
                .HasMany(e => e.PolicyInfoes)
                .WithOptional(e => e.Mst_ProducerCode)
                .HasForeignKey(e => e.Producer_Type);

            modelBuilder.Entity<MST_ProducerName>()
                .HasMany(e => e.Mst_Branch)
                .WithRequired(e => e.MST_ProducerName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MST_ProducerName>()
                .HasMany(e => e.Mst_BrokerCommissions)
                .WithOptional(e => e.MST_ProducerName)
                .HasForeignKey(e => e.Cmm_BrokerCode);

            modelBuilder.Entity<MST_ProducerName>()
                .HasMany(e => e.PolicyInfoes)
                .WithOptional(e => e.MST_ProducerName)
                .HasForeignKey(e => e.Producer_Name);

            modelBuilder.Entity<Mst_Proposal>()
                .HasMany(e => e.Claim_Occurence)
                .WithOptional(e => e.Mst_Proposal)
                .HasForeignKey(e => e.Clm_ProposalCd);

            modelBuilder.Entity<Mst_Proposal>()
                .HasMany(e => e.Claim_Occurence1)
                .WithOptional(e => e.Mst_Proposal1)
                .HasForeignKey(e => e.Clm_LOBType);

            modelBuilder.Entity<Mst_Proposal>()
                .HasMany(e => e.EarnedPremiumTranscations)
                .WithOptional(e => e.Mst_Proposal)
                .HasForeignKey(e => e.Pol_ProposalCode);

            modelBuilder.Entity<Mst_Proposal>()
                .HasMany(e => e.Mst_BrokerCommissions)
                .WithOptional(e => e.Mst_Proposal)
                .HasForeignKey(e => e.Cmm_PropCode);

            modelBuilder.Entity<Mst_Proposal>()
                .HasMany(e => e.Mst_Claim_Range)
                .WithRequired(e => e.Mst_Proposal)
                .HasForeignKey(e => e.Rng_ProposalCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mst_Proposal>()
                .HasMany(e => e.Mst_ClaimLossCause)
                .WithOptional(e => e.Mst_Proposal)
                .HasForeignKey(e => e.Clm_PropCode);

            modelBuilder.Entity<Mst_Proposal>()
                .HasMany(e => e.mst_DocumentType)
                .WithOptional(e => e.Mst_Proposal)
                .HasForeignKey(e => e.Dot_ProposalCode);

            modelBuilder.Entity<Mst_Proposal>()
                .HasMany(e => e.Mst_PolicyTerm)
                .WithOptional(e => e.Mst_Proposal)
                .HasForeignKey(e => e.Ter_PropCode);

            modelBuilder.Entity<Mst_Proposal>()
                .HasMany(e => e.Mst_Question)
                .WithOptional(e => e.Mst_Proposal)
                .HasForeignKey(e => e.Qst_PropCode);

            modelBuilder.Entity<Mst_Proposal>()
                .HasMany(e => e.Mst_SystemVariable)
                .WithOptional(e => e.Mst_Proposal)
                .HasForeignKey(e => e.ProposalCode);

            modelBuilder.Entity<Mst_Proposal>()
                .HasMany(e => e.Mst_Tabs)
                .WithOptional(e => e.Mst_Proposal)
                .HasForeignKey(e => e.Tab_Prp_Code);

            modelBuilder.Entity<Mst_Proposal>()
                .HasMany(e => e.PolicyInfoes)
                .WithOptional(e => e.Mst_Proposal)
                .HasForeignKey(e => e.Pol_ProposalCode);

            modelBuilder.Entity<Mst_Proposal>()
                .HasMany(e => e.PremiumInfoes)
                .WithOptional(e => e.Mst_Proposal)
                .HasForeignKey(e => e.Plan_PropCode);

            modelBuilder.Entity<Mst_Question>()
                .HasMany(e => e.Cmn_QuestionAnswer)
                .WithOptional(e => e.Mst_Question)
                .HasForeignKey(e => e.Ans_QuestionId);

            modelBuilder.Entity<Mst_ReInsurer>()
                .Property(e => e.comm_percent)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Mst_ReInsurer>()
                .Property(e => e.reins_balance)
                .HasPrecision(14, 2);

            modelBuilder.Entity<Mst_ReInsurer>()
                .HasMany(e => e.PolicyInfoes)
                .WithOptional(e => e.Mst_ReInsurer)
                .HasForeignKey(e => e.Lead_Company);

            modelBuilder.Entity<Mst_Relationship>()
                .HasMany(e => e.Claim_Name)
                .WithOptional(e => e.Mst_Relationship)
                .HasForeignKey(e => e.Clm_Relation);

            modelBuilder.Entity<Mst_Salutation>()
                .HasMany(e => e.ClientDetails)
                .WithOptional(e => e.Mst_Salutation)
                .HasForeignKey(e => e.Clt_Salutation);

            modelBuilder.Entity<Mst_Salutation>()
                .HasMany(e => e.ClientDetails1)
                .WithOptional(e => e.Mst_Salutation1)
                .HasForeignKey(e => e.Clt_AppSalutation);

            modelBuilder.Entity<Mst_Salutation>()
                .HasMany(e => e.PolicyHolderInfoes)
                .WithOptional(e => e.Mst_Salutation)
                .HasForeignKey(e => e.Salutation);

            modelBuilder.Entity<Mst_Tabs>()
                .Property(e => e.ControllerName)
                .IsFixedLength();

            modelBuilder.Entity<Mst_Tabs>()
                .Property(e => e.ActionName)
                .IsFixedLength();

            modelBuilder.Entity<Mst_TransType>()
                .HasMany(e => e.EarnedPremiumTranscations)
                .WithOptional(e => e.Mst_TransType)
                .HasForeignKey(e => e.Pol_TransType);

            modelBuilder.Entity<Mst_TransType>()
                .HasMany(e => e.PolicyInfoes)
                .WithOptional(e => e.Mst_TransType)
                .HasForeignKey(e => e.Pol_TransType);

            modelBuilder.Entity<Mst_TransType>()
                .HasMany(e => e.Transaction_Details)
                .WithOptional(e => e.Mst_TransType)
                .HasForeignKey(e => e.Trans_Type);

            modelBuilder.Entity<Mst_TrinreDetail>()
                .Property(e => e.ModuleName)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_TrinreDetail>()
                .Property(e => e.SubModuleName)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_TrinreDetail>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_TrinreDetail>()
                .Property(e => e.CompanyLogoPath)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_TrinreDetail>()
                .Property(e => e.ModifyBy)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_TrinreDetail>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_TrinreDetail>()
                .Property(e => e.CreatedDate)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_Usr>()
                .HasMany(e => e.Claim_Occurence)
                .WithOptional(e => e.Mst_Usr)
                .HasForeignKey(e => e.Clm_AgentID);

            modelBuilder.Entity<Mst_Usr>()
                .HasMany(e => e.ClientDetails)
                .WithOptional(e => e.Mst_Usr)
                .HasForeignKey(e => e.Clt_ApproverId);

            modelBuilder.Entity<Mst_Usr>()
                .HasMany(e => e.Mst_Country)
                .WithOptional(e => e.Mst_Usr)
                .HasForeignKey(e => e.Country_LastModifyBy);

            modelBuilder.Entity<Mst_Usr>()
                .HasMany(e => e.Mst_Coverage)
                .WithOptional(e => e.Mst_Usr)
                .HasForeignKey(e => e.Cov_LastModifyBy);

            modelBuilder.Entity<Mst_Usr>()
                .HasMany(e => e.PremiumInfoes)
                .WithOptional(e => e.Mst_Usr)
                .HasForeignKey(e => e.Appr_UserId);

            modelBuilder.Entity<NavPayment>()
                .Property(e => e.Nav_JournalTemplateName)
                .IsUnicode(false);

            modelBuilder.Entity<NavPayment>()
                .Property(e => e.Nav_AccountType)
                .IsUnicode(false);

            modelBuilder.Entity<NavPayment>()
                .Property(e => e.Nav_AccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<NavPayment>()
                .Property(e => e.Nav_IsPosted)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentInfo>()
                .Property(e => e.Pymnt_CommissionPercent)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PersonalInfo>()
                .Property(e => e.Excess)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PersonalInfo>()
                .Property(e => e.WEarning)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PersonalInfo>()
                .Property(e => e.SumInsured)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PersonalInfo>()
                .HasMany(e => e.Employers)
                .WithOptional(e => e.PersonalInfo)
                .HasForeignKey(e => e.Emp_PersonalInfoId);

            modelBuilder.Entity<PersonalInfo>()
                .HasMany(e => e.Personnel_Identity)
                .WithOptional(e => e.PersonalInfo)
                .HasForeignKey(e => e.Idt_PersonalInfoId);

            modelBuilder.Entity<PersonalInfoTemp>()
                .Property(e => e.Excess)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PersonalInfoTemp>()
                .Property(e => e.WEarning)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PersonalInfoTemp>()
                .Property(e => e.SumInsured)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PersonalInfoTemp>()
                .Property(e => e.Benefits)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PersonalInfoTemp>()
                .HasMany(e => e.MemberAddonCoverageTemps)
                .WithOptional(e => e.PersonalInfoTemp)
                .HasForeignKey(e => e.MemberId);

            modelBuilder.Entity<PersonalInfoTemp>()
                .HasMany(e => e.PersonalInfoTemp1)
                .WithOptional(e => e.PersonalInfoTemp2)
                .HasForeignKey(e => e.PersonalInfoIdRef);

            modelBuilder.Entity<PersonalInfoTemp>()
                .HasOptional(e => e.PersonalInfoTemp11)
                .WithRequired(e => e.PersonalInfoTemp3);

            modelBuilder.Entity<PolicyCoverTemp>()
                .Property(e => e.LoanType)
                .IsUnicode(false);

            modelBuilder.Entity<PolicyCoverTemp>()
                .Property(e => e.Error)
                .IsUnicode(false);

            modelBuilder.Entity<PolicyCoverTemp>()
                .Property(e => e.PremiumMode)
                .IsUnicode(false);

            modelBuilder.Entity<PolicyDocument>()
                .HasMany(e => e.ClientDetails)
                .WithOptional(e => e.PolicyDocument)
                .HasForeignKey(e => e.Clt_Company_DocId);

            modelBuilder.Entity<PolicyDocument>()
                .HasMany(e => e.ClientDetails1)
                .WithOptional(e => e.PolicyDocument1)
                .HasForeignKey(e => e.Clt_FirstPolicyDocId);

            modelBuilder.Entity<PolicyDocument>()
                .HasMany(e => e.ClientDetails2)
                .WithOptional(e => e.PolicyDocument2)
                .HasForeignKey(e => e.Clt_SecondPolicyDocId);

            modelBuilder.Entity<PolicyDocument>()
                .HasMany(e => e.PersonalInfoes)
                .WithOptional(e => e.PolicyDocument)
                .HasForeignKey(e => e.CompanyDocId);

            modelBuilder.Entity<PolicyDocument>()
                .HasMany(e => e.Personnel_Identity)
                .WithOptional(e => e.PolicyDocument)
                .HasForeignKey(e => e.Idt_PolicyDocId);

            modelBuilder.Entity<PolicyInfo>()
                .Property(e => e.Pol_SplDis)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PolicyInfo>()
                .Property(e => e.AdjustmentFrequency)
                .IsFixedLength();

            modelBuilder.Entity<PolicyInfo>()
                .Property(e => e.PaymentFrequency)
                .IsFixedLength();

            modelBuilder.Entity<PolicyInfo>()
                .Property(e => e.PremiumMode)
                .IsUnicode(false);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.Claim_AdjusterNotes)
                .WithOptional(e => e.PolicyInfo)
                .HasForeignKey(e => e.Clm_QuoteNo);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.Claim_Occurence)
                .WithOptional(e => e.PolicyInfo)
                .HasForeignKey(e => e.Clm_QuoteNo);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.Claim_Occurence1)
                .WithOptional(e => e.PolicyInfo1)
                .HasForeignKey(e => e.Clm_QuoteNo);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.Claim_ReinsuranceTransaction)
                .WithOptional(e => e.PolicyInfo)
                .HasForeignKey(e => e.RT_QuoteNo);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.Cmn_Address)
                .WithOptional(e => e.PolicyInfo)
                .HasForeignKey(e => e.Ads_QuoteNo);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.Cmn_QuestionAnswer)
                .WithOptional(e => e.PolicyInfo)
                .HasForeignKey(e => e.Ans_QuoteNo);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.CoinsuranceDetails)
                .WithOptional(e => e.PolicyInfo)
                .HasForeignKey(e => e.Coins_QuoteNo);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.PaymentInfoes)
                .WithOptional(e => e.PolicyInfo)
                .HasForeignKey(e => e.Pymnt_QuoteNo);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.PersonalInfoes)
                .WithRequired(e => e.PolicyInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.PolicyCoverages)
                .WithRequired(e => e.PolicyInfo)
                .HasForeignKey(e => e.PolicyQuoteNo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.PolicyDocuments)
                .WithOptional(e => e.PolicyInfo)
                .HasForeignKey(e => e.Pdo_QuoteNo);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.PolicyHolderInfoes)
                .WithRequired(e => e.PolicyInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.RenewalPolicies)
                .WithOptional(e => e.PolicyInfo)
                .HasForeignKey(e => e.Rn_QuoteNoRef);

            modelBuilder.Entity<PolicyInfo>()
                .HasMany(e => e.Transaction_Details)
                .WithOptional(e => e.PolicyInfo)
                .HasForeignKey(e => e.Trans_Quoteno);

            modelBuilder.Entity<PolicyInfoTemp>()
                .HasMany(e => e.PersonalInfoTemps)
                .WithOptional(e => e.PolicyInfoTemp)
                .HasForeignKey(e => e.PolicyId);

            modelBuilder.Entity<PolicyInfoTemp>()
                .HasMany(e => e.PolicyCoverTemps)
                .WithRequired(e => e.PolicyInfoTemp)
                .HasForeignKey(e => e.PolicyInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PolicyPooledInvestment>()
                .Property(e => e.Percentage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Prem_RateNew>()
                .Property(e => e.SD_Fact)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Prem_RateNew>()
                .Property(e => e.SD_Amount)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PremiumInfo>()
                .Property(e => e.SpecialDiscountComment)
                .IsUnicode(false);

            modelBuilder.Entity<PremiumInfo>()
                .Property(e => e.SpecialSurchargeComment)
                .IsUnicode(false);

            modelBuilder.Entity<PremiumInfo>()
                .HasMany(e => e.Billings)
                .WithOptional(e => e.PremiumInfo)
                .HasForeignKey(e => e.PremId);

            modelBuilder.Entity<ReinsuranceTransaction>()
                .Property(e => e.RT_LimitPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ReinsuranceTransaction>()
                .Property(e => e.RT_CATPerilPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ReinsuranceTransaction>()
                .Property(e => e.RT_NonCATPerilPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ReinsuranceTransaction>()
                .Property(e => e.RT_SumInsuredPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ReinsuranceTransaction>()
                .Property(e => e.RT_CATPerilCommPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ReinsuranceTransaction>()
                .Property(e => e.RT_NonCATPerilCommPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ReinsuranceTransactionHistory>()
                .Property(e => e.RT_History_LimitPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ReinsuranceTransactionHistory>()
                .Property(e => e.RT_History_CATPerilPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ReinsuranceTransactionHistory>()
                .Property(e => e.RT_History_NonCATPerilPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ReinsuranceTransactionHistory>()
                .Property(e => e.RT_History_SumInsuredPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ReinsuranceTransactionHistory>()
                .Property(e => e.RT_History_CATPerilCommPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ReinsuranceTransactionHistory>()
                .Property(e => e.RT_History_NonCATPerilCommPerc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Mst_AnnuityBenefitPlans>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Mst_AnnuityBenefitPlans>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PensionSourceOfFundsTemp>()
                .Property(e => e.CoverageCode)
                .IsUnicode(false);

            modelBuilder.Entity<PensionSourceOfFundsTemp>()
                .Property(e => e.FundSource)
                .IsUnicode(false);

            modelBuilder.Entity<PensionSourceOfFundsTemp>()
                .Property(e => e.SuperAnnuation)
                .IsUnicode(false);

            modelBuilder.Entity<PensionSourceOfFundsTemp>()
                .Property(e => e.PaymentFrequency)
                .IsUnicode(false);

            modelBuilder.Entity<PensionSourceOfFundsTemp>()
                .Property(e => e.PaymentMode)
                .IsUnicode(false);

            modelBuilder.Entity<PensionSourceOfFundsTemp>()
                .Property(e => e.RiskPref)
                .IsUnicode(false);

            modelBuilder.Entity<PensionSourceOfFundsTemp>()
                .Property(e => e.InvestmentApproach)
                .IsUnicode(false);
        }
    }
}
