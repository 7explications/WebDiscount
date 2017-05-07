using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Model;
using Core.Discount.DiscountCalculator;

namespace WebDiscount.Test.Discount
{
    [TestClass]
    public class DiscountTest
    {
        #region Private members
        private IDiscountCalculator discountCalculator;
        private Customer customer;
        private Item item; 
        #endregion

        public DiscountTest()
        {
            discountCalculator = new DiscountCalculator();

            #region Customer
            customer = new Customer
            {
                Id = 1,
                Type = EnumTypes.CustomerType.StoreEmployee,
                DateFirstPurchase = DateTime.Now,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            }; 
            #endregion

            #region Item
            item = new Item
            {
                Id = 1,
                Amount = 990,
                Category = EnumTypes.ItemCategory.PercentageBaseDiscount,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            }; 
            #endregion
        }

        #region Store Employee Test
        [TestMethod]
        public void StoreEmployeePercentageBaseRuleTest()
        {
            //Arrange 
            customer.Type = EnumTypes.CustomerType.StoreEmployee;
            item.Category = EnumTypes.ItemCategory.PercentageBaseDiscount;
            //Act 
            var discount = discountCalculator.CalculateDiscount(customer, item);
            //Assert 
            Assert.AreEqual(discount, 990 * .30m);
        }

        [TestMethod]
        public void StoreEmployeeAmountBaseRuleTest()
        {
            //Arrange 
            customer.Type = EnumTypes.CustomerType.StoreEmployee;
            item.Category = EnumTypes.ItemCategory.AmountBaseDiscount;
            //Act 
            var discount = discountCalculator.CalculateDiscount(customer, item);
            //Assert 
            Assert.AreEqual(discount, 9 * 5m);
        }

        #endregion

        #region Affiliate Of Store Test
        [TestMethod]
        public void AffiliatePercentageBaseRuleTest()
        {
            //Arrange 
            customer.Type = EnumTypes.CustomerType.AffiliateOfStore;
            item.Category = EnumTypes.ItemCategory.PercentageBaseDiscount;
            //Act 
            var discount = discountCalculator.CalculateDiscount(customer, item);
            //Assert 
            Assert.AreEqual(discount, 990 * .10m);
        }

        [TestMethod]
        public void AffiliateAmountBaseRuleTest()
        {
            //Arrange 
            customer.Type = EnumTypes.CustomerType.AffiliateOfStore;
            item.Category = EnumTypes.ItemCategory.AmountBaseDiscount;
            //Act 
            var discount = discountCalculator.CalculateDiscount(customer, item);
            //Assert 
            Assert.AreEqual(discount, 9 * 5m);
        }

        #endregion

        #region TwoYear Test
        [TestMethod]
        public void TwoYearPercentageBaseRuleTest()
        {
            //Arrange 
            customer.Type = EnumTypes.CustomerType.ExistingCutomer;
            customer.DateFirstPurchase = DateTime.Parse("02/02/2014");
            item.Category = EnumTypes.ItemCategory.PercentageBaseDiscount;
            //Act 
            var discount = discountCalculator.CalculateDiscount(customer, item);
            //Assert 
            Assert.AreEqual(discount, 990 * .05m);
        }

        [TestMethod]
        public void TwoYearAmountBaseRuleTest()
        {
            //Arrange 
            customer.Type = EnumTypes.CustomerType.ExistingCutomer;
            item.Category = EnumTypes.ItemCategory.AmountBaseDiscount;
            //Act 
            var discount = discountCalculator.CalculateDiscount(customer, item);
            //Assert 
            Assert.AreEqual(discount, 9 * 5m);
        }
        #endregion
    }

}
