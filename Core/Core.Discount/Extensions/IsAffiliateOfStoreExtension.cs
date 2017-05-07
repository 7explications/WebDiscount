using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Discount.Extensions
{
    public static class IsAffiliateOfStoreExtension
    {
        public static bool IsAffiliateOfStore(this Customer customer)
        {
            return customer.Type == EnumTypes.CustomerType.AffiliateOfStore ? true : false;

        }
    }
}
