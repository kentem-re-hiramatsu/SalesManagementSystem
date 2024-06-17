using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sales.Core;
using System;

namespace SalesManagementTest.ModelTest
{
    [TestClass]
    public class ProductTest
    {
        /// <summary>
        /// 正しく仕入れできているか。
        /// </summary>
        [TestMethod]
        public void PurchaseOrderTest()
        {
            var product = new Product("りんご", 5, 50, 120);

            Assert.AreEqual("りんご", product.ProductName);
            Assert.AreEqual(5, product.PurchaseQuantity);
            Assert.AreEqual(2, product.SalesQuantity);
            Assert.AreEqual(120, product.PurchasePrice);
        }

        /// <summary>
        /// 商品名に数値が入力されたとき
        /// </summary>
        [TestMethod]
        public void PurchaseOrderInputNameErrorTest()
        {
            Assert.ThrowsException<Exception>(() => new Product(0, -1, 50, 120));
            Assert.ThrowsException<Exception>(() => new Product(-1, -1, 50, 120));
        }

        /// <summary>
        /// 仕入れ数、仕入れ価格、販売価格に文字列が入力されたとき
        /// </summary>
        [TestMethod]
        public void PurchaseOrderInputStringErrorTest()
        {
            Assert.ThrowsException<Exception>(() => new Product("みかん", 50, 6, 120));
            Assert.ThrowsException<Exception>(() => new Product("みかん", 50, "6", 120));
            Assert.ThrowsException<Exception>(() => new Product("みかん", 50, 6, "120"));
        }

        /// <summary>
        /// 仕入れ数、仕入れ価格、販売価格に０または-1が入力されたとき
        /// </summary>
        [TestMethod]
        public void PurchaseOrderInputZeroErrorTest()
        {
            Assert.ThrowsException<Exception>(() => new Product("みかん", 0, 50, 120));
            Assert.ThrowsException<Exception>(() => new Product("みかん", -1, 50, 120));

            Assert.ThrowsException<Exception>(() => new Product("みかん", 5, 0, 120));
            Assert.ThrowsException<Exception>(() => new Product("みかん", 5, -1, 120));

            Assert.ThrowsException<Exception>(() => new Product("みかん", 5, 50, 0));
            Assert.ThrowsException<Exception>(() => new Product("みかん", 5, 50, -1));
        }

        /// <summary>
        /// 販売数を入力したときに在庫数が更新されるか
        /// </summary>
        [TestMethod]
        public void PurchaseOrderSetStockQuantityTest()
        {
            var product = new Product("みかん", 5, 50, 120);
            Assert.AreEqual(0, product.StockQuantity);

            product.SetPurchaseQuantity(4);
            Assert.AreEqual(4, product.StockQuantity);
        }

        /// <summary>
        /// 在庫数より販売数が上回っているとき
        /// </summary>
        [TestMethod]
        public void PurchaseOrderStockQuantityErrorTest()
        {
            var product = new Product("みかん", 5, 50, 120);
            Assert.ThrowsException<Exception>(() => product.SetPurchaseQuantity(6));
            Assert.ThrowsException<Exception>(() => product.SetPurchaseQuantity(0));
            Assert.ThrowsException<Exception>(() => product.SetPurchaseQuantity(-1));
        }

        /// <summary>
        /// 商品の売上金額、利益金額を返す
        /// </summary>
        [TestMethod]
        public void PurchaseOrderPurchaseQuantityErrorTest()
        {
            var product = new Product("みかん", 5, 50, 120);
            product.SetPurchaseQuantity(4);

            int salesAmount = 120 * 4;
            int IncomeAmount = salesAmount - 50 * 4;

            Assert.AreEqual(salesAmount, product.GetSalesAmount());
            Assert.AreEqual(IncomeAmount, product.GetIncomeAmount());
        }
    }
}
