using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    public class Appliance : Product
    {
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public double Weight { get; set; }

        public override double GetDiscount(DateTime dateOfPurchase)
        {
            if ((dateOfPurchase.DayOfWeek == DayOfWeek.Saturday || dateOfPurchase.DayOfWeek == DayOfWeek.Sunday)
                && Price > 999)
            {
                return 0.05;
            }

            return 0.0;
        }

        public override string ToString()
        {
            return $"{Name} {Brand} {Model}";
        }
    }
}
