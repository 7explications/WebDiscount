using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Model.EnumTypes;

namespace Core.Model
{
    public class Item : Entity
    {
        public string ItemName { get; set; }
        public decimal Amount { get; set; }
        public ItemCategory Category { get; set; }
    }
}
