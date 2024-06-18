﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SalesManagementTest.ModelTest
{
    [TestClass]
    public class PurchaseTest
    {
        /// <summary>
        /// 正しくコンストラクタが動作しているか。
        /// </summary>
        [TestMethod]
        public void PurchaseConstructorTest()
        {
            var purchase = new Product.Core.Model.Purchase("りんご", 5, 80);
            var nowDateTime = DateTime.Now;

            Assert.AreEqual("りんご", purchase.ProductName);
            Assert.AreEqual(5, purchase.PurchaseQuantity);
            Assert.AreEqual(80, purchase.PurchasePrice);
            Assert.AreEqual(nowDateTime, purchase.PurchaseDateTime);

            Assert.ThrowsException<Exception>(() => new Product.Core.Model.Purchase("みかん", 0, 90));
            Assert.ThrowsException<Exception>(() => new Product.Core.Model.Purchase("みかん", -1, 90));

            Assert.ThrowsException<Exception>(() => new Product.Core.Model.Purchase("みかん", 5, 0));
            Assert.ThrowsException<Exception>(() => new Product.Core.Model.Purchase("みかん", 5, -1));
        }
    }
}
