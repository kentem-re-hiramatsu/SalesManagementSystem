﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.Core.Manager;
using Product.Core.Model;

namespace SalesManagementTest.ManagerTest
{
    [TestClass]
    public class SalesManagerTest
    {
        SalesManager salesmana = new SalesManager();

        [TestMethod]
        public void AddTest()
        {
            var cherry = new Sales(200, new Purchase("さくらんぼ", 5, 100));
            var Banana = new Sales(300, new Purchase("バナナ", 3, 150));
            Assert.AreEqual(0, salesmana.SalesList.Count);

            salesmana.Add(cherry);
            salesmana.Add(Banana);

            Assert.AreEqual(2, salesmana.SalesList.Count);
            Assert.AreEqual(200, salesmana.GetSales(0).SalesPrice);
            Assert.AreEqual(300, salesmana.GetSales(1).SalesPrice);
        }

        [TestMethod]
        public void TotalSalesAndTotalIncomeAmountTest()
        {
            var cherryPuchase = new Purchase("さくらんぼ", 5, 100);
            var bananaPuchase = new Purchase("バナナ", 3, 150);
            var cherry = new Sales(200, cherryPuchase);
            var banana = new Sales(300, bananaPuchase);

            cherry.ProcessSales(2);
            banana.ProcessSales(1);

            salesmana.Add(cherry);
            salesmana.Add(banana);

            var cherryPuchasePrice = 100;
            var cherrySalesPrice = 200;
            var cherrySalesQuantity = 2;

            var bananaPuchasePrice = 150;
            var bananaSalesPrice = 300;
            var bananaSalesQuantity = 1;

            var totalSalesAmount = cherrySalesPrice * cherrySalesQuantity + bananaSalesPrice * bananaSalesQuantity;
            var totalIncomeAmount = totalSalesAmount - ((cherryPuchasePrice * cherrySalesQuantity) + (bananaPuchasePrice * bananaSalesQuantity));

            Assert.AreEqual(totalSalesAmount, salesmana.GetTotalSalesAmount());
            Assert.AreEqual(totalIncomeAmount, salesmana.GetTotalIncomeAmount());
        }
    }
}
