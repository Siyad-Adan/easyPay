﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace easyPay.Entity
{
    public class PaymentRecord
    {
        public int Id { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [MaxLength(100)]
        public string FullName { get; set; }
        public string SSN { get; set; }
        public DateTime PayDate { get; set; }
        public string PayMonth { get; set; }
        [ForeignKey("TaxYear")]
        public int TaxYearId { get; set; }
        public TaxYear TaxYear { get; set; }
        public string TaxCode { get; set; }
        
        public decimal HourlyRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal HoursWorked { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ContractualHours { get; set; }
        
        public decimal OvertimeHours { get; set; }
        
        public decimal ContractualEarnings { get; set; }
        
        public decimal OvertimeEarnings { get; set; }
        
        public decimal Tax { get; set; }
        
        public decimal SSC { get; set; }
        
        public decimal? UnionFee { get; set; }
        
        public decimal? SLC { get; set; }
        
        public decimal TotalEarnings { get; set; }
        
        public decimal TotalDeduction { get; set; }
        
        public decimal NetPayment { get; set; }

    }
}
