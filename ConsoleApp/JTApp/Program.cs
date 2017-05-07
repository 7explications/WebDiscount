using Core.Discount.DiscountCalculator;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {

            WriteLine("========================================================================");
            BillPrint();
            WriteLine("========================================================================");
            Read();
        }

        private static void BillPrint()
        {
            #region Data
            Customer customer = new Customer
            {
                Id = 1,
                CustomerName = "Test Customer",
                Type = EnumTypes.CustomerType.StoreEmployee,
                DateFirstPurchase = null,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            };


            List<Item> items = new List<Item>
            {
                new Item
                {
                Id = 1,
                ItemName="Item1",
                Amount = 990,
                Category = EnumTypes.ItemCategory.PercentageBaseDiscount,
                IsDeleted = false,
                CreatedDate = DateTime.Now
                },
                 new Item
                {
                Id = 2,
                ItemName="Item2",
                Amount = 990,
                Category = EnumTypes.ItemCategory.AmountBaseDiscount,
                IsDeleted = false,
                CreatedDate = DateTime.Now
                }
            };
            #endregion
            Print(customer, items);
        }

        private static void Print(Customer customer,List<Item> items)
        {
            IDiscountCalculator dC = new DiscountCalculator();
            WriteLine("Date:{0}\t\tName:{1}\t",DateTime.Now,customer.CustomerName);
            WriteLine("========================================================================");
            WriteLine("ID\t|Item\t\t|Amount\t\t|Discount\t|NetAmount");
            WriteLine("========================================================================");
            decimal totalAmount = 0;
            foreach (var item in items)
            {
                decimal discount = dC.CalculateDiscount(customer,item);
                decimal netAmount = item.Amount - discount;
                totalAmount += netAmount;
                WriteLine("{0}\t|{1}\t\t|{2}\t\t|{3}\t\t|{4}",item.Id,item.ItemName,item.Amount, discount, netAmount);
            }
            WriteLine("========================================================================");
            WriteLine("\t\t\t\t\tTotal Amount\t|{0}",totalAmount);
        }

    }
}
