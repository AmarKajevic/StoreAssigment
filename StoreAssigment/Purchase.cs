using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
    public class Purchase
    {
        private readonly Product product;
        private readonly double quantity;
        private readonly DateTime dateOfPurchase;

        public Purchase(Product product, double quantity, DateTime dateOfPurchase)
        {
            this.product = product;
            this.quantity = quantity;
            this.dateOfPurchase = dateOfPurchase;
        }

        public double Sum => Math.Round(quantity * product.Price, 2);

        public double Discount => Math.Round(Sum * product.GetDiscount(dateOfPurchase), 2);

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{product}");
            sb.AppendLine($"{quantity} x {product.Price} = {Sum}");
            if (product.GetDiscount(dateOfPurchase) != 0.0)
            {
                sb.AppendLine($"#discount {product.GetDiscountInPercent(dateOfPurchase)} = {Discount}");
            }
            return sb.ToString();
        }
    }
}
