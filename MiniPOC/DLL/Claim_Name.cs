namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Claim_Name
    {
        [Key]
        public int Clm_Id { get; set; }

        public int Clm_ClaimNo { get; set; }

        public int? Clm_InsuredCd { get; set; }

        [StringLength(100)]
        public string Clm_MName { get; set; }

        [StringLength(100)]
        public string Clm_LName { get; set; }

        [StringLength(100)]
        public string Clm_SName { get; set; }

        public DateTime? Clm_Dob { get; set; }

        public int? Clm_Age { get; set; }

        [StringLength(4)]
        public string Clm_ClmntCountry { get; set; }

        public int? Clm_ClmntCountryId { get; set; }

        [StringLength(50)]
        public string Clm_ClmnttParish { get; set; }

        public int? Clm_ClmnttParishId { get; set; }

        [StringLength(50)]
        public string Clm_ClmntCity { get; set; }

        public int? Clm_ClmntCityId { get; set; }

        [StringLength(50)]
        public string Clm_ClmntSuberb { get; set; }

        public int? Clm_ClmntSuberbId { get; set; }

        [StringLength(50)]
        public string Clm_ClmntStreet { get; set; }

        public int? Clm_ClmntStreetId { get; set; }

        [StringLength(20)]
        public string Clm_ClmntZip { get; set; }

        [StringLength(100)]
        public string Clm_ClmntPOBox { get; set; }

        [StringLength(12)]
        public string Clm_Mobile1 { get; set; }

        [StringLength(12)]
        public string Clm_Mobile2 { get; set; }

        [StringLength(18)]
        public string Clm_Office_Phone { get; set; }

        [StringLength(12)]
        public string Clm_Home_Phone { get; set; }

        [StringLength(18)]
        public string Clm_Fax { get; set; }

        [StringLength(100)]
        public string Clm_EmailAdd { get; set; }

        [StringLength(50)]
        public string Clm_IdentityType { get; set; }

        [StringLength(15)]
        public string Clm_IdentityNo { get; set; }

        [StringLength(100)]
        public string Clm_DamageDesc { get; set; }

        [StringLength(100)]
        public string Clm_DamageLoc { get; set; }

        public DateTime? Clm_DamageDt { get; set; }

        [StringLength(100)]
        public string Clm_BusinessDesc { get; set; }

        [StringLength(1)]
        public string Clm_MaritalStatus { get; set; }

        [StringLength(1)]
        public string Clm_Sex { get; set; }

        [StringLength(4)]
        public string Clm_Relation { get; set; }

        [StringLength(3)]
        public string Clm_PType { get; set; }

        public bool? Clm_Claimant { get; set; }

        [StringLength(1)]
        public string Clm_Party { get; set; }

        [StringLength(50)]
        public string Clm_WitnessLocation { get; set; }

        [StringLength(50)]
        public string Clm_StmtObtained { get; set; }

        [StringLength(50)]
        public string Clm_Perspective { get; set; }

        [StringLength(500)]
        public string Clm_PropDesc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Clm_LossEst { get; set; }

        [StringLength(1)]
        public string Clm_OtherInfo { get; set; }

        [StringLength(50)]
        public string Clm_DriverLicenseState { get; set; }

        [StringLength(15)]
        public string Clm_UsedFor { get; set; }

        [StringLength(1)]
        public string Clm_LiveWithInsured { get; set; }

        [StringLength(1)]
        public string Clm_VehicleatAddr { get; set; }

        [StringLength(200)]
        public string Clm_AddNote { get; set; }

        public int? Clm_DriverId { get; set; }

        [StringLength(25)]
        public string Clm_DrvrLicense { get; set; }

        public DateTime? Clm_DrvrLicenseIssuedt { get; set; }

        public DateTime? Clm_DrvrLicenseExpdt { get; set; }

        public int? Clm_LicenseType { get; set; }

        [StringLength(50)]
        public string Clm_LicenseClass { get; set; }

        [StringLength(25)]
        public string Clm_LicenseClassVh { get; set; }

        public int? Clm_LicenseClassVhId { get; set; }

        public int? Clm_LicenseTypeId { get; set; }

        [StringLength(1)]
        public string Clm_Loss { get; set; }

        public decimal? Clm_SumInsured { get; set; }

        [StringLength(50)]
        public string Clm_Qualification { get; set; }

        public DateTime? Clm_Incapacitated_Date_From1 { get; set; }

        public DateTime? Clm_Incapacitated_Date_From2 { get; set; }

        public DateTime? Clm_Incapacitated_Date_To1 { get; set; }

        public DateTime? Clm_Incapacitated_Date_To2 { get; set; }

        public bool? Clm_OtherPolicy { get; set; }

        [StringLength(100)]
        public string Clm_OtherPolicyDetail { get; set; }

        [StringLength(100)]
        public string Clm_Occupation { get; set; }

        [StringLength(1000)]
        public string Clm_Address1 { get; set; }

        public int? Clm_ZoneId { get; set; }

        public int? Clm_AreaId { get; set; }

        public int? Clm_BlockId { get; set; }

        public int? Clm_RiskId { get; set; }

        [StringLength(4)]
        public string Clm_LicenseCountry { get; set; }

        [StringLength(50)]
        public string Clm_LicenseCity { get; set; }

        [StringLength(100)]
        public string Clm_PoliceStation { get; set; }

        public int? Clm_VehicleId { get; set; }

        public DateTime? Clm_DrvrLicenseRenewDate { get; set; }

        [StringLength(25)]
        public string Clm_SecondDrvrLicense { get; set; }

        public DateTime? Clm_SecondDrvrLicenseIssuedt { get; set; }

        public DateTime? Clm_SecondDrvrLicenseExpdt { get; set; }

        public int? Clm_SecondLicenseType { get; set; }

        [StringLength(4)]
        public string Clm_SecondLicenseCountry { get; set; }

        [StringLength(50)]
        public string Clm_SecondLicenseCity { get; set; }

        [StringLength(50)]
        public string Clm_SecondLicenseClass { get; set; }

        public DateTime? Clm_SecondDrvrLicenseRenewDate { get; set; }

        [StringLength(2)]
        public string Clm_IsClaimant { get; set; }

        [StringLength(2)]
        public string Clm_SubrogationStatus { get; set; }

        [StringLength(2)]
        public string Clm_LitigationStatus { get; set; }

        [StringLength(2)]
        public string Clm_SalvageStatus { get; set; }

        [StringLength(50)]
        public string Clm_CarrierList { get; set; }

        [StringLength(50)]
        public string Clm_PolicyNo { get; set; }

        public int? Clm_PropertyId { get; set; }

        [StringLength(100)]
        public string Clm_CompanyName { get; set; }

        [StringLength(500)]
        public string Clm_Document { get; set; }

        [StringLength(500)]
        public string Clm_SecondDocument { get; set; }

        [StringLength(10)]
        public string Clm_ClaimCd { get; set; }

        [StringLength(100)]
        public string Clm_EmployeeName { get; set; }

        [StringLength(1)]
        public string Clm_vehicleRegistered { get; set; }

        [StringLength(50)]
        public string clm_VehicleRegisteredDetail { get; set; }

        [StringLength(50)]
        public string Clm_HowLongEmployed { get; set; }

        [StringLength(1)]
        public string Clm_DriverMotorVehicle { get; set; }

        [StringLength(20)]
        public string Clm_DriverVehicleRegNo { get; set; }

        [StringLength(20)]
        public string Clm_DriverPolicyNo { get; set; }

        [StringLength(1)]
        public string Clm_PhysicalImapirment { get; set; }

        [StringLength(50)]
        public string Clm_PhysicalImapirmentDetail { get; set; }

        [StringLength(1)]
        public string Clm_DriverTrafficOffence { get; set; }

        [StringLength(50)]
        public string Clm_DriverTrafficOffenceDetail { get; set; }

        [StringLength(50)]
        public string Clm_DriverInAccident { get; set; }

        [StringLength(5)]
        public string Clm_WitnessType { get; set; }

        [StringLength(15)]
        public string Clm_VatRegistrationNo { get; set; }

        [StringLength(100)]
        public string Clm_DriverCompanyName { get; set; }

        public int? Clm_TPCd { get; set; }

        [StringLength(50)]
        public string Clm_CompReg { get; set; }

        [StringLength(2)]
        public string Clm_ProposerType { get; set; }

        [StringLength(5)]
        public string Clm_LitigationStat { get; set; }

        [StringLength(50)]
        public string Clm_HighCourtNoticeNumber { get; set; }

        public DateTime? Clm_DateOfAction { get; set; }

        public DateTime? Clm_DateFiled { get; set; }

        public DateTime? Clm_DateServed { get; set; }

        public DateTime? Clm_NextDate { get; set; }

        [StringLength(10)]
        public string Clm_OurAtorney { get; set; }

        [StringLength(10)]
        public string Clm_ThirdAttorney { get; set; }

        [StringLength(500)]
        public string Clm_ReviewCode { get; set; }

        public DateTime? Clm_Review_Pending_Date { get; set; }

        public DateTime? Clm_CloseDate { get; set; }

        [StringLength(500)]
        public string Clm_CloseComments { get; set; }

        [StringLength(1)]
        public string Clm_CloseStatus { get; set; }

        public DateTime? Clm_ReopenDate { get; set; }

        [StringLength(500)]
        public string Clm_ReopenComments { get; set; }

        [StringLength(100)]
        public string Clm_Examiner { get; set; }

        [StringLength(100)]
        public string Clm_ExaminerName { get; set; }

        public DateTime? Clm_ExaminerDate { get; set; }

        [StringLength(100)]
        public string Clm_Adjuster { get; set; }

        [StringLength(100)]
        public string Clm_AdjusterName { get; set; }

        public DateTime? Clm_AdjusterDate { get; set; }

        [StringLength(100)]
        public string Clm_Investigator { get; set; }

        [StringLength(100)]
        public string Clm_InvestigatorName { get; set; }

        public DateTime? Clm_InvestigatorDate { get; set; }

        public DateTime? Clm_AdjusterRetDate { get; set; }

        [StringLength(15)]
        public string Clm_BadgeNo { get; set; }

        [StringLength(1000)]
        public string Clm_AccidentDetail { get; set; }

        [StringLength(5)]
        public string Clm_PolicyLocationType { get; set; }

        [StringLength(1)]
        public string Clm_PhysicalImpairment { get; set; }

        [StringLength(500)]
        public string Clm_ImpairmentsValue { get; set; }

        [StringLength(2000)]
        public string Clm_ImpairmentsText { get; set; }

        [StringLength(20)]
        public string Clm_Zip { get; set; }

        public virtual Claim_Occurence Claim_Occurence { get; set; }

        public virtual Mst_AddressArea Mst_AddressArea { get; set; }

        public virtual Mst_AddressBlock Mst_AddressBlock { get; set; }

        public virtual Mst_AddressRisk Mst_AddressRisk { get; set; }

        public virtual Mst_AddressZone Mst_AddressZone { get; set; }

        public virtual Mst_Country Mst_Country { get; set; }

        public virtual Mst_Country Mst_Country1 { get; set; }

        public virtual Mst_Country Mst_Country2 { get; set; }

        public virtual mst_DocumentType mst_DocumentType { get; set; }

        public virtual mst_DocumentType mst_DocumentType1 { get; set; }

        public virtual Mst_Relationship Mst_Relationship { get; set; }
    }
}
