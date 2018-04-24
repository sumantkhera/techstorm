namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonalInfoTemp")]
    public partial class PersonalInfoTemp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonalInfoTemp()
        {
            MemberAddonCoverageTemps = new HashSet<MemberAddonCoverageTemp>();
            MemberCoverageInfoTemps = new HashSet<MemberCoverageInfoTemp>();
            MemberLoanTemps = new HashSet<MemberLoanTemp>();
            PersonalInfoTemp1 = new HashSet<PersonalInfoTemp>();
            PersonnelIdentityTemps = new HashSet<PersonnelIdentityTemp>();
        }

        [Key]
        public int PersonalInfoId { get; set; }

        public int QuoteNo { get; set; }

        public int? SequenceNo { get; set; }

        [StringLength(4)]
        public string Salutation { get; set; }

        [StringLength(100)]
        public string FName { get; set; }

        [StringLength(100)]
        public string MName { get; set; }

        [StringLength(100)]
        public string LName { get; set; }

        public DateTime? Dob { get; set; }

        [StringLength(20)]
        public string Relation { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [StringLength(1)]
        public string Marital { get; set; }

        [StringLength(20)]
        public string Height { get; set; }

        [StringLength(20)]
        public string Weight { get; set; }

        [StringLength(15)]
        public string Weight_Unit { get; set; }

        [StringLength(4)]
        public string Driver_Type { get; set; }

        public int? NationalityId { get; set; }

        [StringLength(10)]
        public string Driver_Frequency { get; set; }

        [StringLength(2000)]
        public string CompanyTypeId { get; set; }

        [StringLength(12)]
        public string Mobile1 { get; set; }

        [StringLength(12)]
        public string Mobile2 { get; set; }

        [StringLength(18)]
        public string Office_Phone { get; set; }

        [StringLength(12)]
        public string Home_Phone { get; set; }

        [StringLength(18)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string EmailAdd { get; set; }

        [StringLength(1)]
        public string InfoType { get; set; }

        public int? PostalAddressId { get; set; }

        public int? CorsAddressId { get; set; }

        public int? OpnDrvNo { get; set; }

        public int? UndAgeNo { get; set; }

        public int? InExpNo { get; set; }

        public int? BothOpnDrvNo { get; set; }

        public int? ReferenceId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Excess { get; set; }

        [StringLength(2)]
        public string EmpType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WEarning { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SumInsured { get; set; }

        [StringLength(10)]
        public string Class { get; set; }

        [StringLength(50)]
        public string ClassTyp { get; set; }

        public int? PersonalInfoIdRef { get; set; }

        public DateTime? TransactionDate { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(10)]
        public string VAT_Reg { get; set; }

        [StringLength(20)]
        public string GroupCompany { get; set; }

        [StringLength(4)]
        public string Occupation { get; set; }

        public int? Company_DocId { get; set; }

        [StringLength(50)]
        public string Company_RegNo { get; set; }

        [StringLength(1)]
        public string Accident_History { get; set; }

        public DateTime? Course_Completion_Date { get; set; }

        [StringLength(20)]
        public string Security_Control_No { get; set; }

        public int? Experience { get; set; }

        public int? CountryOfBirth { get; set; }

        [StringLength(1)]
        public string InsuredAsDriver { get; set; }

        [StringLength(100)]
        public string Restrictions { get; set; }

        public int? FitnessCertificate_DocId { get; set; }

        [StringLength(5)]
        public string OwnerShip { get; set; }

        public bool? IsDobDefault { get; set; }

        public int? BoatingExperience { get; set; }

        [StringLength(100)]
        public string BoatingQualification { get; set; }

        [StringLength(500)]
        public string CriminalDesc { get; set; }

        public int? BoatingDocId { get; set; }

        [StringLength(20)]
        public string SocialSecurity { get; set; }

        [StringLength(20)]
        public string CIF { get; set; }

        [StringLength(50)]
        public string FormReceivedBy { get; set; }

        public bool? IsAdminFee { get; set; }

        [StringLength(100)]
        public string PersonName { get; set; }

        [StringLength(50)]
        public string Height1 { get; set; }

        [StringLength(50)]
        public string Weight1 { get; set; }

        public bool? IsTabaco { get; set; }

        public bool? IsAlcohol { get; set; }

        public int? Nationality { get; set; }

        public decimal? Benefits { get; set; }

        public int? SelectedApplicantId { get; set; }

        [StringLength(25)]
        public string CeritficateNo { get; set; }

        public DateTime? DateEffective { get; set; }

        public DateTime? DateExpiry { get; set; }

        public DateTime? DateAdded { get; set; }

        public bool? IsActive1 { get; set; }

        public string Errors { get; set; }

        public bool? HasErrors { get; set; }

        public int? ExcelId { get; set; }

        public int? PolicyId { get; set; }

        public int? Age { get; set; }

        public decimal? BrokerPremium { get; set; }

        public bool? IsUploaded { get; set; }

        [StringLength(50)]
        public string AddDelete { get; set; }

        public decimal? Premium { get; set; }

        public decimal? BrokerCommission { get; set; }

        public string ErrorMemberInfo { get; set; }

        public string ErrorCreditorLife { get; set; }

        public string ErrorAdAndD { get; set; }

        public string ErrorGroupLife { get; set; }

        public string ErrorFuneralGrant { get; set; }

        public string ErrorCritiacalIllness { get; set; }

        public string ErrorInvoluntary { get; set; }

        [StringLength(50)]
        public string ClientId { get; set; }

        [StringLength(16)]
        public string LoanClientId { get; set; }

        [StringLength(5)]
        public string CoverageCode { get; set; }

        public virtual AddressTemp AddressTemp { get; set; }

        public virtual AddressTemp AddressTemp1 { get; set; }

        public virtual ExcelInformation ExcelInformation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberAddonCoverageTemp> MemberAddonCoverageTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberCoverageInfoTemp> MemberCoverageInfoTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberLoanTemp> MemberLoanTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalInfoTemp> PersonalInfoTemp1 { get; set; }

        public virtual PersonalInfoTemp PersonalInfoTemp2 { get; set; }

        public virtual PersonalInfoTemp PersonalInfoTemp11 { get; set; }

        public virtual PersonalInfoTemp PersonalInfoTemp3 { get; set; }

        public virtual PolicyInfoTemp PolicyInfoTemp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonnelIdentityTemp> PersonnelIdentityTemps { get; set; }
    }
}
