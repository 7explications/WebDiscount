using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Discount.DiscountCalculator
{
    
    public interface IDiscountCalculator
    {
        decimal CalculateDiscount(Customer customer, Item item);
    }
}
