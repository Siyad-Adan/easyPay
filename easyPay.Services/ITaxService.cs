using System;
using System.Collections.Generic;
using System.Text;

namespace easyPay.Services
{
    public interface ITaxService
    {
        decimal TaxAmount(decimal totalAmount);
    }
}
