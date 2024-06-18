﻿using System;

namespace Sales.Core.Model
{
    public class Purchase
    {
        public string ProductName { get; }
        public int PurchaseQuantity { get; }
        public int PurchasePrice { get; }
        public DateTime PurchaseDateTime { get; }

        public Purchase(string name, int purchaseQuantity, int price)
        {
            ProductName = name;

            if (purchaseQuantity > 0 && price > 0)
            {
                PurchaseQuantity = purchaseQuantity;
                PurchasePrice = price;
            }
            else
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }
            PurchaseDateTime = DateTime.Now;
        }
    }
}
