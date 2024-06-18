using System;

namespace Product.Core.Model
{
    public class Sales
    {
        public int SalesPrice { get; }
        public int SalesQuantity { get; }
        public DateTime SalesDataTime { get; }
        public int StockQuantity { get; }

        public Sales(int price, int purchaseQuantity)
        {
            if (price > 0 && purchaseQuantity > 0)
            {
                SalesPrice = price;
                StockQuantity = purchaseQuantity;
            }
            else
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }
            SalesDataTime = DateTime.Now;
        }
    }
}
