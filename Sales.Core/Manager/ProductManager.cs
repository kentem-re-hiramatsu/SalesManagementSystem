using System.Collections.Generic;

namespace Sales.Core.Manager
{
    public class ProductManager
    {
        private List<Product> _salesList = new List<Product>();

        public IReadOnlyCollection<Product> SalesList { get { return _salesList; } }

        public void Add(Product product)
        {
            _salesList.Add(product);
        }

        public Product GetSalesList(int index)
        {
            return _salesList[index];
        }

        public int GetTotalSalesAmount()
        {
            var totalSalesAmount = 0;

            foreach (Product product in _salesList)
            {
                totalSalesAmount += product.GetSalesAmount();
            }

            return totalSalesAmount;
        }

        public int GetTotalIncomeAmount()
        {
            var TotalIncomeAmount = 0;

            foreach (Product product in _salesList)
            {
                TotalIncomeAmount += product.GetIncomeAmount();
            }

            return TotalIncomeAmount;
        }
    }
}
