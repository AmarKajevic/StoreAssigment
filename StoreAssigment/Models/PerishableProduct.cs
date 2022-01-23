using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    public class PerishableProduct : Product
    {
        public DateTime ExpirationDate { get; set; }

        public override double GetDiscount(DateTime dateOfPurchase)
        {
            if (ExpirationDate.Date == dateOfPurchase.Date)
            {
                return 0.5;
            }

            if (ExpirationDate.Date >= dateOfPurchase.AddDays(-5).Date && ExpirationDate.Date <= dateOfPurchase.Date)
            {
                return 0.1;
            }

            return 0.0;
        }

        public override string ToString()
        {
            return $"{Name} {Brand}";
        }
    }
}