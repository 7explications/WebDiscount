using Core.Discount.Extensions;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Discount.Rules
{
    public class ExistingTwoYearCustomerRule : IDiscountRule
    {

        public decimal CalculateDiscount(Customer customer, Item item)
        {
            return customer.IsExistingTwoYearCustomer() ? item.Amount * .05m : 0;
        }
    }
}
