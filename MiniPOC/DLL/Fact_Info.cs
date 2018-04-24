namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fact_Info
    {
        public int? SerialNo { get; set; }

        public int? MemberID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuoteNo { get; set; }

        public int? ClientId { get; set; }

        [StringLength(200)]
        public string FirstName { get; set; }

        [StringLength(200)]
        public string CompanyName { get; set; }

        [StringLength(200)]
        public string MiddleName { get; set; }

        [StringLength(200)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string ApartmentNo { get; set; }

        [StringLength(200)]
        public string Address1 { get; set; }

        [StringLength(200)]
        public string Address2 { get; set; }

        [StringLength(200)]
        public string State { get; set; }

        [StringLength(200)]
        public string Country { get; set; }

        public int? ZipCode { get; set; }

        public int? Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string SocialSecurityNo { get; set; }

        [StringLength(50)]
        public string TaxPayerID { get; set; }

        [StringLength(50)]
        public string County { get; set; }

        [StringLength(50)]
        public string Emp_Designation { get; set; }

        [StringLength(50)]
        public string Manager { get; set; }

        [StringLength(50)]
        public string MG_Address1 { get; set; }

        [StringLength(50)]
        public string MG_Address2 { get; set; }

        [StringLength(50)]
        public string MG_State { get; set; }

        [StringLength(50)]
        public string MG_County { get; set; }

        [StringLength(50)]
        public string MG_Country { get; set; }

        public int? MG_ZipCode { get; set; }

        [StringLength(50)]
        public string MG_EmployerID { get; set; }

        [StringLength(50)]
        public string CompanyRegNo { get; set; }

        [StringLength(50)]
        public string ProposerType { get; set; }

        [StringLength(50)]
        public string PolicyType { get; set; }
    }
}
