namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientDetail
    {
        public int ClientDetailId { get; set; }

        public int? Clt_ClientId { get; set; }

        [StringLength(1)]
        public string Clt_ProposerType { get; set; }

        [StringLength(4)]
        public string Clt_Salutation { get; set; }

        [StringLength(100)]
        public string Clt_FName { get; set; }

        [StringLength(100)]
        public string Clt_MName { get; set; }

        [StringLength(100)]
        public string Clt_LName { get; set; }

        public DateTime? Clt_Dob { get; set; }

        [StringLength(1)]
        public string Clt_Gender { get; set; }

        [StringLength(1)]
        public string Clt_Marital { get; set; }

        public int? Clt_NationalityId { get; set; }

        public int? Clt_CountryOfBirth { get; set; }

        [StringLength(4)]
        public string Clt_Occupation { get; set; }

        public bool? Clt_IsProposer { get; set; }

        [StringLength(4)]
        public string Clt_AppSalutation { get; set; }

        [StringLength(100)]
        public string Clt_AppFName { get; set; }

        [StringLength(100)]
        public string Clt_AppMName { get; set; }

        [StringLength(100)]
        public string Clt_AppLName { get; set; }

        public DateTime? Clt_AppDob { get; set; }

        [StringLength(1)]
        public string Clt_AppGender { get; set; }

        [StringLength(1)]
        public string Clt_AppMarital { get; set; }

        public int? Clt_AppNationalityId { get; set; }

        public int? Clt_AppCountryOfBirth { get; set; }

        [StringLength(4)]
        public string Clt_AppOccupation { get; set; }

        [StringLength(12)]
        public string Clt_PhoneNo { get; set; }

        [StringLength(12)]
        public string Clt_AltPhoneNo { get; set; }

        [StringLength(12)]
        public string Clt_CellularNo { get; set; }

        [StringLength(50)]
        public string Clt_EmailAddress { get; set; }

        [StringLength(50)]
        public string Clt_EmpCompanyName { get; set; }

        public int? Clt_EmpAddressId { get; set; }

        [StringLength(10)]
        public string Clt_EmpPhone { get; set; }

        [StringLength(4)]
        public string Clt_EmpPhoneExt { get; set; }

        [StringLength(50)]
        public string Clt_EmpEmailAddress { get; set; }

        [StringLength(50)]
        public string Clt_EmpPosition { get; set; }

        public int? Clt_Salary { get; set; }

        [StringLength(10)]
        public string Clt_EmpFax { get; set; }

        [StringLength(1)]
        public string Clt_EmpSalaryType { get; set; }

        [StringLength(1)]
        public string Clt_EmpCurrencyType { get; set; }

        public int? Clt_PostalAddressId { get; set; }

        public int? Clt_CorsAddressId { get; set; }

        [StringLength(2000)]
        public string Clt_CompanyTypeId { get; set; }

        [StringLength(50)]
        public string Clt_Company_RegNo { get; set; }

        [StringLength(20)]
        public string Clt_GroupCompany { get; set; }

        [StringLength(5)]
        public string Clt_Ownership { get; set; }

        public int? Clt_Company_DocId { get; set; }

        [StringLength(1000)]
        public string Clt_Company_DocPath { get; set; }

        [StringLength(25)]
        public string Clt_FirstIdentityVal { get; set; }

        public DateTime? Clt_FirstIssue_Dt { get; set; }

        public DateTime? Clt_FirstExpiry_Dt { get; set; }

        public int? Clt_FirstLic_Type { get; set; }

        [StringLength(50)]
        public string Clt_FirstClass { get; set; }

        [StringLength(4)]
        public string Clt_FirstCountry { get; set; }

        [StringLength(50)]
        public string Clt_FirstCity { get; set; }

        [StringLength(500)]
        public string Clt_FirstClassValue { get; set; }

        public DateTime? Clt_FirstRenew_Dt { get; set; }

        public int? Clt_FirstPolicyDocId { get; set; }

        [StringLength(1000)]
        public string Clt_First_IDDocPath { get; set; }

        [StringLength(25)]
        public string Clt_SecondIdentityVal { get; set; }

        public DateTime? Clt_SecondIssue_Dt { get; set; }

        public DateTime? Clt_SecondExpiry_Dt { get; set; }

        public int? Clt_SecondLic_Type { get; set; }

        [StringLength(50)]
        public string Clt_SecondClass { get; set; }

        [StringLength(4)]
        public string Clt_SecondCountry { get; set; }

        [StringLength(50)]
        public string Clt_SecondCity { get; set; }

        [StringLength(500)]
        public string Clt_SecondClassValue { get; set; }

        public DateTime? Clt_SecondRenew_Dt { get; set; }

        public int? Clt_SecondPolicyDocId { get; set; }

        [StringLength(1000)]
        public string Clt_Second_IDDocPath { get; set; }

        public DateTime? Clt_TransDate { get; set; }

        [StringLength(10)]
        public string Clt_ApproverId { get; set; }

        [StringLength(10)]
        public string Clt_ApproverStatus { get; set; }

        public DateTime? Clt_ApproveDate { get; set; }

        public bool? Clt_IsDobDefault { get; set; }

        public virtual Mst_Salutation Mst_Salutation { get; set; }

        public virtual mst_DocumentType mst_DocumentType { get; set; }

        public virtual Cmn_Address Cmn_Address { get; set; }

        public virtual Cmn_Address Cmn_Address1 { get; set; }

        public virtual Cmn_Address Cmn_Address2 { get; set; }

        public virtual Mst_Country Mst_Country { get; set; }

        public virtual Mst_Country Mst_Country1 { get; set; }

        public virtual mst_DocumentType mst_DocumentType1 { get; set; }

        public virtual Mst_Nationality Mst_Nationality { get; set; }

        public virtual Mst_Nationality Mst_Nationality1 { get; set; }

        public virtual Mst_Nationality Mst_Nationality2 { get; set; }

        public virtual Mst_Nationality Mst_Nationality3 { get; set; }

        public virtual Mst_Salutation Mst_Salutation1 { get; set; }

        public virtual Mst_Usr Mst_Usr { get; set; }

        public virtual PolicyDocument PolicyDocument { get; set; }

        public virtual PolicyDocument PolicyDocument1 { get; set; }

        public virtual PolicyDocument PolicyDocument2 { get; set; }
    }
}
