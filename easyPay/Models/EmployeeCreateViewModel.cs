using easyPay.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace easyPay.Models
{
    public class EmployeeCreateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Employee Number is required"), 
            RegularExpression("^[A-Z]{3,3}[0-9]{3}$")]
        public string EmployeeNo { get; set; }
        [RegularExpression(@"^\d{3}[-]?\d{3}[-]?\d{4}$")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "First Name is required"), StringLength(50, MinimumLength = 2),
            RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(50), Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Last Name is required"), StringLength(50, MinimumLength = 2),
            RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FullName { 
            get {
                return FirstName + (string.IsNullOrEmpty(MiddleName) ? "" : (" " + (char?)MiddleName[0] + ". ").ToUpper()) + " " +  LastName;
            } }
        public string Gender { get; set; }
        [Display(Name = "Photo")]
        public IFormFile ImageUrl { get; set; }
        [DataType(DataType.Date), Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }
        [DataType(DataType.Date), Display(Name = "Date Joined")]
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;
        [Required(ErrorMessage ="Job Role is required"), StringLength(100)]
        public string Designation { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, StringLength(50), Display(Name = "Social Security No."),
            RegularExpression(@"^\d{9}$")]
        public string SocialSecurityNumber { get; set; }
        [Display(Name = "Payment Method")]
        public PaymentMethod PaymentMethod { get; set; }
        [Display(Name = "Student Loan")]
        public StudentLoan StudentLoan { get; set; }
        [Display(Name = "Union Member")]
        public UnionMember UnionMember { get; set; }
        [Required, StringLength(150)]
        public string Address { get; set; }
        [Required, StringLength(50)]
        public string City { get; set; }
        [Required, StringLength(50), RegularExpression(@"^[A-Za-z]\d[A-Za-z][-]?\d[A-Za-z]\d$")]
        public string Postcode { get; set; }
        public IEnumerable<PaymentRecord> PaymentRecords { get; set; }
    }
}
