using System;
using System.Collections.Generic;
using System.Text;

namespace easyPay.Services
{
    public class TaxService : ITaxService
    {
        private decimal taxRate;
        private decimal tax;
        public decimal TaxAmount(decimal totalAmount)
        {
            if (totalAmount <= 916.67m)
            {
                tax = 0;
            }
            else if (totalAmount > 916.67m && totalAmount <= 4044.58m) {
                taxRate = 0.15m;
                tax = totalAmount * taxRate;
            }
            else if (totalAmount > 4044.58m && totalAmount <= 8089.08m)
            {
                taxRate = 0.205m;
                tax = totalAmount * taxRate;
            }
            else if (totalAmount > 8089.08m && totalAmount <= 12539.42m)
            {
                taxRate = 0.26m;
                tax = totalAmount * taxRate;
            }
            else if (totalAmount > 12539.42m && totalAmount <= 17864.0m)
            {
                taxRate = 0.29m;
                tax = totalAmount * taxRate;
            }
            else
            {
                taxRate = 0.33m;
                tax = totalAmount * taxRate;
            }

            return tax;

        }
    }
}
