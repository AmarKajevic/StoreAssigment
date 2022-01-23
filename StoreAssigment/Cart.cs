using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
    public class Cart
    {
        private readonly List<Purchase> purchases;
        private readonly DateTime dateOfPurchase;

        public Cart(DateTime dateOfPurchase)
        {
            purchases = new List<Purchase>();
            this.dateOfPurchase = dateOfPurchase;
        }

        public void AddPurchase(Product product, double quantity)
        {
            this.purchases.Add(new Purchase(product, quantity, dateOfPurchase));
        }

        public DateTime DateOfPurchase => dateOfPurchase;

        public IReadOnlyList<Purchase> Purchases => this.purchases;
    }
}
