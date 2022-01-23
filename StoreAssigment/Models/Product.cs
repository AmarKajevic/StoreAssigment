using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    public abstract class Product
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

        public abstract double GetDiscount(DateTime dateOfPurchase);

        public string GetDiscountInPercent(DateTime dateOfPurchase)
        {
            if (GetDiscount(dateOfPurchase) != 0.0)
            {
                return GetDiscount(dateOfPurchase) * 100 + "%";
            }

            return string.Empty;
        }
    }
}