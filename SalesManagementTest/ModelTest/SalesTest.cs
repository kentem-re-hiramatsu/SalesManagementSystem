using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sales.Core.Model;
using System;

namespace SalesManagementTest.ModelTest
{
    [TestClass]
    public class SalesTest
    {
        [TestMethod]
        public void SalesConstructorTest()
        {
            var sales = new Sales(100, 5);

            Assert.AreEqual(100, sales.SalesPrice);
            Assert.AreEqual(5, sales.StockQuantity);

            Assert.ThrowsException<Exception>(() => new Sales(0, 5));
            Assert.ThrowsException<Exception>(() => new Sales(-1, 5));

            Assert.ThrowsException<Exception>(() => new Sales(100, 0));
            Assert.ThrowsException<Exception>(() => new Sales(100, -1));
        }

        [TestMethod]
        public void ProcessSalesTest()
        {
            var sales = new Sales(100, 5);
            Assert.AreEqual(5, sales.StockQuantity);

            sales.ProcessSales(3);
            Assert.AreEqual(3, sales.SalesQuantity);
            Assert.AreEqual(2, sales.StockQuantity);
        }

        [TestMethod]
        public void TotaltSalesAmountAndTotalIncomeAmountTest()
        {
            var sales = new Sales(200, 4);
            sales.ProcessSales(3);

            var salesPrice = 200;
            var salesQuantity = 3;
            var salesAmount = salesPrice * salesQuantity;

            Assert.AreEqual(salesAmount, sales.GetSalesAmount());

            var purchase = new Purchase("バナナ", 6, 50);

            var purchasePrice = purchase.PurchasePrice;
            var costPrice = purchasePrice * salesQuantity;
            var incomeAmount = salesAmount - costPrice;

            Assert.AreEqual(incomeAmount, sales.GetIncomeAmount());
        }
    }
}
