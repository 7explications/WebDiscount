using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Discount.Rules
{
    public interface IDiscountRule
    {
        decimal CalculateDiscount(Customer customer, Item item);
    }
}
