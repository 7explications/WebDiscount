using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Discount.Rules
{
    public class Amount100BaseDiscountRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer, Item item)
        {
            return Discount(item) * 5m;
        }
        private Int64 Discount(Item item)
        {
            return (Int64) item.Amount / 100;
        }
    }
}
