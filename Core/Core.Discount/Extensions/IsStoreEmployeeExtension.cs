using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Discount.Extensions
{
    public static class IsStoreEmployeeExtension
    {
        public static bool IsStoreEmployee(this Customer customer)
        {
            //theck the custome is Store Employee and retuen true or fale
            return customer.Type == EnumTypes.CustomerType.StoreEmployee ? true : false;
        }
    }
}
