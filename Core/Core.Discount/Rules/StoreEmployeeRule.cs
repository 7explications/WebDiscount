using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Discount.Extensions;

namespace Core.Discount.Rules
{
    public class StoreEmployeeRul : IDiscountRule
    {

        public decimal CalculateDiscount(Customer customer, Item item)
        {
           
            return customer.IsStoreEmployee() ? item.Amount * 0.30m : 0;
        }
    }
}
