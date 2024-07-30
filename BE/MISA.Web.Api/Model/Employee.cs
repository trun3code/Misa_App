﻿using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace MISA.Web.Api.Model
{
    public class Employee
    {
        [Dapper.Contrib.Extensions.Key]
        public Guid EmployeeID { get; set; }
        [Required] public string? EmployeeCode { get; set; }
        [Required] public string? FullName { get; set; }
        public int? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [Required] public string? PhoneNumber { get; set; }
        [Required] public string? Email { get; set; }
        public string? Address { get; set; }
        [Required] public string? IdentityNumber { get; set; }
        public DateTime? IdentityDate { get; set; }
        public string? IdentityPlace { get; set; }
        public string? LandlineNumber { get; set; }
        public string? BankAccount { get; set; }
        public string? BankName { get; set; }
        public string? BankBranch { get; set; }
        public Guid PositionId { get; set; }
        public Guid DepartmentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
