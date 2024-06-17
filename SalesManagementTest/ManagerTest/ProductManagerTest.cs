using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sales.Core;
using Sales.Core.Manager;

namespace SalesManagementTest.ManagerTest
{
    [TestClass]
    public class ProductManagerTest
    {
        ProductManager productmana = new ProductManager();

        [TestMethod]
        public void GetSalesList()
        {
            Assert.AreEqual(0, productmana.SalesList.Count);
            var mikan = new Product("みかん", 5, 50, 120);
            var apple = new Product("りんご", 3, 80, 150);

            productmana.Add(mikan);
            productmana.Add(apple);

            Assert.AreEqual(2, productmana.SalesList.Count);
            Assert.AreEqual("みかん", productmana.GetSalesList(0).ProductName);
            Assert.AreEqual("りんご", productmana.GetSalesList(1).ProductName);
        }
    }
}
