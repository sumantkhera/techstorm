namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employer")]
    public partial class Employer
    {
        public int EmployerId { get; set; }

        [StringLength(50)]
        public string Emp_Name { get; set; }

        [StringLength(50)]
        public string Emp_Occupation { get; set; }

        [StringLength(50)]
        public string Emp_Trade_Business { get; set; }

        [StringLength(50)]
        public string Emp_Nature_Work { get; set; }

        public int? Emp_AddressId { get; set; }

        public int? Emp_PersonalInfoId { get; set; }

        public bool? Emp_IsActive { get; set; }

        [StringLength(10)]
        public string Emp_Phone { get; set; }

        [StringLength(4)]
        public string Emp_PhoneExt { get; set; }

        [StringLength(50)]
        public string Emp_Email { get; set; }

        [StringLength(50)]
        public string Emp_Position { get; set; }

        public int? Salary { get; set; }

        [StringLength(10)]
        public string Emp_Fax { get; set; }

        [StringLength(1)]
        public string Emp_SalaryType { get; set; }

        [StringLength(1)]
        public string Emp_CurrencyType { get; set; }

        [StringLength(2)]
        public string EmploymentType { get; set; }

        [StringLength(50)]
        public string PrevEmployerName { get; set; }

        [StringLength(50)]
        public string PrevPostionHeld { get; set; }

        [StringLength(50)]
        public string PrevEmployedDuration { get; set; }

        [StringLength(50)]
        public string EmpDuration { get; set; }

        public virtual Cmn_Address Cmn_Address { get; set; }

        public virtual PersonalInfo PersonalInfo { get; set; }
    }
}
