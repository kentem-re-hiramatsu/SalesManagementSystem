using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.Core.Manager;

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
            var mikan = new Product.Core.Product("みかん", 5, 50, 120);
            var apple = new Product.Core.Product("りんご", 3, 80, 150);

            mikan.ProcessSale(4);
            apple.ProcessSale(2);

            productmana.Add(mikan);
            productmana.Add(apple);

            Assert.AreEqual(2, productmana.SalesList.Count);
            Assert.AreEqual("みかん", productmana.GetSalesList(0).ProductName);
            Assert.AreEqual("りんご", productmana.GetSalesList(1).ProductName);

            int mikanSalesPrice = 120;
            int mikanPurchasePrice = 50;
            int mikanSalesQuantity = 4;

            int appleSalesPrice = 150;
            int applePurchasePrice = 80;
            int appleSalesQuantity = 2;

            int totalSalesAmount = mikanSalesPrice * mikanSalesQuantity + appleSalesPrice * appleSalesQuantity;
            int totalIncomeAmount = (mikanSalesPrice - mikanPurchasePrice) * mikanSalesQuantity + (appleSalesPrice - applePurchasePrice) * appleSalesQuantity;

            Assert.AreEqual(totalSalesAmount, productmana.GetTotalSalesAmount());
            Assert.AreEqual(totalIncomeAmount, productmana.GetTotalIncomeAmount());
        }
    }
}
