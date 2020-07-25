using easyPay.Entity;
using easyPay.Models;
using easyPay.Models.PaymentRecord;
using easyPay.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace easyPay.Controllers
{
    public class PayController : Controller
    {
        private readonly IPayComputationService _payComputationService;
        private readonly IEmployeeService _employeeService;
        private readonly ITaxService _taxService;
        private decimal overtimeHrs;
        private decimal contractualEarnings;
        private decimal overtimeEarnings;
        private decimal totalEarnings;
        private decimal tax;
        private decimal unionFee;
        private decimal studentLoan;
        private decimal totalDeduction;
        public PayController(IPayComputationService payComputationService, IEmployeeService employeeService, ITaxService taxService)
        {
            _payComputationService = payComputationService;
            _employeeService = employeeService;
            _taxService = taxService;
        }

        public IActionResult Index()
        {
            var payRecords = _payComputationService.GetAll().Select(p => new PaymentRecordIndexViewModel
            {
                Id = p.Id,
                EmployeeId = p.EmployeeId,
                Employee = p.Employee,
                FullName = p.FullName,
                PayDate = p.PayDate,
                PayMonth = p.PayMonth,
                TaxYearId = p.TaxYearId,
                Year = _payComputationService.GetTaxYearById(p.TaxYearId).YearOfTax,
                TotalEarnings = p.TotalEarnings,
                TotalDeduction = p.TotalDeduction,
                NetPayment = p.NetPayment

            });
            return View(payRecords);
        }

        public IActionResult Create()
        {
            ViewBag.employees = _employeeService.GetAllEmployeesForPayroll();
            ViewBag.taxYears = _payComputationService.AllGetTaxYear();
            var model = new PaymentRecordCreateViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PaymentRecordCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var payrecord = new PaymentRecord()
                {
                    Id = model.Id,
                    EmployeeId = model.EmployeeId,
                    FullName = _employeeService.GetById(model.Id).FullName,
                    SSN = _employeeService.GetById(model.EmployeeId).SocialSecurityNumber,
                    PayDate = model.PayDate,
                    PayMonth = model.PayMonth,
                    TaxYearId = model.TaxYearId,
                    TaxCode = model.TaxCode,
                    HourlyRate = model.HourlyRate,
                    HoursWorked = model.HoursWorked,
                    ContractualHours = model.ContractualHours,
                    OvertimeHours = overtimeHrs = _payComputationService.OvertimeHours(model.HoursWorked, model.ContractualHours),
                    ContractualEarnings = contractualEarnings = _payComputationService.ContractualEarnings(model.ContractualHours, model.HoursWorked, model.HourlyRate),
                    OvertimeEarnings = overtimeEarnings = _payComputationService.OvertimeEarnings(_payComputationService.OvertimeRate(model.HourlyRate), overtimeHrs),
                    TotalEarnings = totalEarnings = _payComputationService.TotalEarnings(overtimeEarnings, contractualEarnings),
                    Tax = tax = _taxService.TaxAmount(totalEarnings),
                    UnionFee = unionFee = _employeeService.UnionFees(model.EmployeeId),
                    SLC = studentLoan = _employeeService.StudentLoanRepaymentAmount(model.EmployeeId, totalEarnings),
                    TotalDeduction = totalDeduction = _payComputationService.TotalDeduction(tax, studentLoan, unionFee),
                    NetPayment = _payComputationService.NetPay(totalEarnings, totalDeduction)
                };
                await _payComputationService.CreateAsync(payrecord);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.employees = _employeeService.GetAllEmployeesForPayroll();
            ViewBag.taxYears = _payComputationService.AllGetTaxYear();
            return View();
        }


    }
}
