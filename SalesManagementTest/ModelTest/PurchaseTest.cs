using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sales.Core.Model;
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
        public void PurchaseOrderTest()
        {
            var purchase = new Purchase("りんご", 5, 80);
            var nowDateTime = DateTime.Now;

            Assert.AreEqual("りんご", purchase.ProductName);
            Assert.AreEqual(5, purchase.PurchaseQuantity);
            Assert.AreEqual(80, purchase.PurchasePrice);
            Assert.AreEqual(nowDateTime, purchase.PurchaseDateTime);
        }

        /// <summary>
        /// 仕入れ数、仕入れ価格に０または-1が入力されたとき
        /// </summary>
        [TestMethod]
        public void PurchaseOrderInputZeroErrorTest()
        {
            Assert.ThrowsException<Exception>(() => new Purchase("みかん", 0, 90));
            Assert.ThrowsException<Exception>(() => new Purchase("みかん", -1, 90));

            Assert.ThrowsException<Exception>(() => new Purchase("みかん", 5, 0));
            Assert.ThrowsException<Exception>(() => new Purchase("みかん", 5, -1));
        }
    }
}
