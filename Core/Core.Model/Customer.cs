using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Model.EnumTypes;

namespace Core.Model
{
    public class Customer : Entity
    {
        public string CustomerName { get; set; }
        public CustomerType Type { get; set; }
        public DateTime? DateFirstPurchase { get; set; }


    }
}
