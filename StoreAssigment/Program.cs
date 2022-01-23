using StoreApp.Models;
using System;
using System.Collections.Generic;

namespace StoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateOfPurchase = new DateTime(2021, 6, 14, 12, 34, 56);

            var apple = new Food
            {
                Name = "apple",
                Brand = "Brand A",
                Price = 1.50,
                ExpirationDate = new DateTime(2021, 6, 14)
            };

            var milk = new Food
            {
                Name = "milk",
                Brand = "Brand M",
                Price = 0.99,
                ExpirationDate = new DateTime(2022, 2, 2)
            };

            var tShirt = new Cloth
            {
                Name = "T-shirt",
                Brand = "BrandT",
                Size = Size.M,
                Color = "violet",
                Price = 15.99
            };

            var laptop = new Appliance
            {
                Name = "laptop",
                Brand = "BrandL",
                Price = 2345,
                Model = "ModelL",
                ProductionDate = new DateTime(2021, 3, 3),
                Weight = 1.125
            };

            var cart = new Cart(dateOfPurchase);
            cart.AddPurchase(apple, 2.45);
            cart.AddPurchase(milk, 3);
            cart.AddPurchase(tShirt, 2);
            cart.AddPurchase(laptop, 1);

            Cashier.PrintReceipt(cart);
        }
    }
}
