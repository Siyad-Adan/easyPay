﻿using easyPay.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace easyPay.Models
{
    public class PaymentRecordIndexViewModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Display(Name = "Month")]
        public DateTime PayDate { get; set; }
        public string PayMonth { get; set; }
        public int TaxYearId { get; set; }
        public string Year { get; set; }
        [Display(Name ="Total Earnings")]
        public decimal TotalEarnings { get; set; }
        [Display(Name = "Total Deductions")]
        public decimal TotalDeduction { get; set; }
        [Display(Name = "Net")]
        public decimal NetPayment { get; set; }
    }
}
