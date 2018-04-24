namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonalInfo")]
    public partial class PersonalInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonalInfo()
        {
            Employers = new HashSet<Employer>();
            MemberCoverageInfoes = new HashSet<MemberCoverageInfo>();
            MemberLoans = new HashSet<MemberLoan>();
            Personnel_Identity = new HashSet<Personnel_Identity>();
        }

        public int PersonalInfoId { get; set; }

        public int QuoteNo { get; set; }

        public int? SequenceNo { get; set; }

        [StringLength(4)]
        public string Salutation { get; set; }

        [StringLength(12)]
        public string Mobile1 { get; set; }

        public int? PostalAddressId { get; set; }

        public int? CountryOfBirth { get; set; }

        [StringLength(1)]
        public string InsuredAsDriver { get; set; }

        [StringLength(100)]
        public string Restrictions { get; set; }

        [StringLength(50)]
        public string Height { get; set; }

        [StringLength(50)]
        public string Weight { get; set; }

        public bool? IsTabaco { get; set; }

        public bool? IsAlcohol { get; set; }

        public int? Nationality { get; set; }

        public decimal? Benefits { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string MiddleName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        public DateTime? Dob { get; set; }

        [StringLength(20)]
        public string Relation { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [StringLength(1)]
        public string Marital { get; set; }

        [StringLength(15)]
        public string WeightUnit { get; set; }

        [StringLength(4)]
        public string DriverType { get; set; }

        public int? NationalityId { get; set; }

        [StringLength(10)]
        public string DriverFrequency { get; set; }

        [StringLength(2000)]
        public string CompanyTypeId { get; set; }

        [StringLength(12)]
        public string Mobile2 { get; set; }

        [StringLength(18)]
        public string OfficePhone { get; set; }

        [StringLength(12)]
        public string HomePhone { get; set; }

        [StringLength(18)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string EmailAdd { get; set; }

        [StringLength(1)]
        public string InfoType { get; set; }

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
        public string VATRegNo { get; set; }

        [StringLength(20)]
        public string GroupCompany { get; set; }

        [StringLength(4)]
        public string Occupation { get; set; }

        public int? CompanyDocId { get; set; }

        [StringLength(50)]
        public string CompanyRegNo { get; set; }

        [StringLength(1)]
        public string AccidentHistory { get; set; }

        public DateTime? CourseCompletionDate { get; set; }

        [StringLength(20)]
        public string SecurityControlNo { get; set; }

        public int? Experience { get; set; }

        public int? FitnessCertificateDocId { get; set; }

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

        public bool? IsManualUpload { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        public int? SelectedApplicantId { get; set; }

        public DateTime? DateAdded { get; set; }

        public DateTime? DateUpdated { get; set; }

        public DateTime? DateEffective { get; set; }

        public DateTime? DateExpiry { get; set; }

        public int? Age { get; set; }

        [StringLength(14)]
        public string ClientId { get; set; }

        [StringLength(10)]
        public string CertificateNo { get; set; }

        public decimal? Premium { get; set; }

        public decimal? Commission { get; set; }

        public decimal? NetPremium { get; set; }

        [StringLength(100)]
        public string WebsiteAddress { get; set; }

        public bool? IsBeneficiaryForCL { get; set; }

        [StringLength(14)]
        public string LoanClientId { get; set; }

        [StringLength(5)]
        public string CoverageCode { get; set; }

        public virtual Cmn_Address Cmn_Address { get; set; }

        public virtual Cmn_Address Cmn_Address1 { get; set; }

        public virtual Cmn_Address Cmn_Address2 { get; set; }

        public virtual Cmn_Address Cmn_Address3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employer> Employers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberCoverageInfo> MemberCoverageInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberLoan> MemberLoans { get; set; }

        public virtual Mst_Nationality Mst_Nationality { get; set; }

        public virtual Mst_Nationality Mst_Nationality1 { get; set; }

        public virtual PolicyDocument PolicyDocument { get; set; }

        public virtual PolicyInfo PolicyInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personnel_Identity> Personnel_Identity { get; set; }
    }
}
