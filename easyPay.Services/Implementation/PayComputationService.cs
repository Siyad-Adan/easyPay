using easyPay.Entity;
using easyPay.Persistence;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyPay.Services.Implementation
{
    class PayComputationService : IPayComputationService
    {
        private readonly ApplicationDbContext _context;
        private decimal contractualEarnings;
        private decimal overtimeHours;
        public PayComputationService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<SelectListItem> AllGetTaxYear()
        {
            var allTaxYear = _context.TaxYears.Select(taxYears => new SelectListItem
            {
                Text = taxYears.YearOfTax,
                Value = taxYears.Id.ToString()
            });

            return allTaxYear;
        }

        public decimal ContractualEarnings(decimal contractualHours, decimal hoursWorked, decimal hourlyRate)
        {
            if (hoursWorked < contractualHours)
                contractualEarnings = hoursWorked * hourlyRate;
            else
                contractualEarnings = contractualHours * hourlyRate;

            return contractualEarnings;
        }

        public async Task CreateAsync(PaymentRecord paymentRecord)
        {
            await _context.PaymentRecords.AddAsync(paymentRecord);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<PaymentRecord> GetAll() => 
            _context.PaymentRecords.OrderBy(p => p.EmployeeId);

        public PaymentRecord GetById(int id) =>
            _context.PaymentRecords.Where(p => p.Id == id).FirstOrDefault();

        public decimal NetPay(decimal totalEarnings, decimal totalDeductions) =>
            totalEarnings - totalDeductions;

        public decimal OvertimeEarnings(decimal overtimeRate, decimal overtimeHours) =>
            overtimeHours * overtimeRate;

        public decimal OvertimeHours(decimal hoursWorked, decimal contractualHours)
        {
            if (hoursWorked <= contractualHours)
                overtimeHours = 0.00m;
            else
                overtimeHours = hoursWorked - contractualHours;

            return overtimeHours;
        }

        public decimal OvertimeRate(decimal hourlyRate) =>
            hourlyRate * 1.5m;

        public decimal TotalDeduction(decimal tax, decimal federalTax, decimal provincialTax, decimal ccpEiPremiums, decimal studentLoanRepayment, decimal unionFees) =>
            tax + federalTax + provincialTax + ccpEiPremiums + studentLoanRepayment + unionFees;

        public decimal TotalEarnings(decimal overtimeEarnings, decimal contractualEarnings) =>
            overtimeEarnings + contractualEarnings;
    }
}
