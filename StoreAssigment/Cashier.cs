using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
    public class Cashier
    {
        public static void PrintReceipt(Cart cart)
        {
            if (cart == null || cart.Purchases == null || !cart.Purchases.Any())
            {
                Console.WriteLine("You have to purchase something!");
                return;
            }

            Console.WriteLine($"Date: {cart.DateOfPurchase.ToString("yyyy-MM-dd HH:mm:ss")}");
            Console.WriteLine();

            Console.WriteLine("---Products---");
            double subTotal = 0;
            double discount = 0;
            foreach (var purchase in cart.Purchases)
            {
                Console.WriteLine(purchase);
                subTotal += purchase.Sum;
                discount += purchase.Discount;
            }

            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine($"SUBTOTAL: {subTotal}");
            Console.WriteLine($"DISCOUNT: {discount}");
            Console.WriteLine($"TOTAL: {Math.Round(subTotal - discount, 2)}");
        }
    }
}

