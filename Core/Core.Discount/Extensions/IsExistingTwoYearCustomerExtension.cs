using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Discount.Extensions
{
    public static class IsExistingTwoYearCustomerExtension
    {
        public static bool IsExistingTwoYearCustomer(this Customer customer)
        {
            if (!customer.IsExisting())
                return false;
            return customer.TwoYear();

        }
        public static bool TwoYear(this Customer customer)
        {
            DateTime oldDate = customer.DateFirstPurchase.HasValue ? customer.DateFirstPurchase.Value : DateTime.Now;
            if (oldDate.AddYears(2) <= DateTime.Now)
                return true;
            else
                return false;
        }

        public static bool IsExisting(this Customer customer)
        {
            return customer.DateFirstPurchase.HasValue;
        }
    }
}
