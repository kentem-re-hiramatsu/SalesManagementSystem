using System;

namespace Sales.Core
{
    public class Product
    {
        public string ProductName { get; }
        public int PurchasePrice { get; }
        public DateTime PurchaseDate { get; }
        public DateTime SalesDate { get; }
        public int SalesPrice { get; }
        public int SalesQuantity { get; private set; }
        public int StockQuantity { get; private set; }

        public Product(string productName, int purchaseQuantity, int purchasePrice, int salesPrice)
        {
            PurchaseDate = DateTime.Now;
            ProductName = productName;

            if (purchaseQuantity > 0 && purchasePrice > 0 && salesPrice > 0)
            {
                StockQuantity = purchaseQuantity;
                PurchasePrice = purchasePrice;
                SalesPrice = salesPrice;
            }
            else
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }
        }

        public int GetSalesAmount()
        {
            return SalesPrice * SalesQuantity;
        }

        public int GetIncomeAmount()
        {
            return (SalesPrice - PurchasePrice) * SalesQuantity;
        }

        public void ProcessSale(int quantity)
        {
            if (quantity > 0 && StockQuantity >= quantity)
            {
                SalesQuantity = quantity;
                StockQuantity -= quantity;
            }
            else
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }
        }
    }
}
