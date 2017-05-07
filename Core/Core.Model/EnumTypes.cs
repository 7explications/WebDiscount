using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class EnumTypes
    {
        public enum CustomerType
        {
            StoreEmployee = 1,
            AffiliateOfStore = 2,
            ExistingCutomer = 3,
            NewCustomer = 9
        }

        public enum ItemCategory
        {
            PercentageBaseDiscount = 1,
            AmountBaseDiscount = 2
        }
    }
}
