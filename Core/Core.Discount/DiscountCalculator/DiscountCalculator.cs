using Core.Discount.Rules;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Model.EnumTypes;

namespace Core.Discount.DiscountCalculator
{
    public class DiscountCalculator : IDiscountCalculator
    {
        List<IDiscountRule> percentageBasrules = new List<IDiscountRule>();
        List<IDiscountRule> amountBasrules = new List<IDiscountRule>();
        public DiscountCalculator()
        {
            try
            { 
            percentageBasrules.Add(new StoreEmployeeRul());
            percentageBasrules.Add(new AffiliateOfStoreRule());
            percentageBasrules.Add(new ExistingTwoYearCustomerRule());
            amountBasrules.Add(new Amount100BaseDiscountRule());
            }
            catch
            {
                throw;
            }
        }

        public decimal CalculateDiscount(Customer customer, Item item)
        {
            try
            {
                decimal discount = 0;
                if (item.Category == ItemCategory.PercentageBaseDiscount)
                {
                    foreach (var rule in percentageBasrules)
                    {
                        discount = rule.CalculateDiscount(customer, item);
                        if (discount > 0) break;
                    }
                }
                else if (item.Category == ItemCategory.AmountBaseDiscount)
                {
                    foreach (var rule in amountBasrules)
                    {
                        discount = rule.CalculateDiscount(customer, item);
                    }
                }

                return discount;
            }
            catch
            {
                throw;
            }
        }
    }
}
