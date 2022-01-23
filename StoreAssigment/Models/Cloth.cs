using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    public class Cloth : Product
    {
        public Size Size { get; set; }
        public string Color { get; set; }

        public override double GetDiscount(DateTime dateOfPurchase)
        {
            switch (dateOfPurchase.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    return 0.1;
                default:
                    return 0.0;
            }
        }

        public override string ToString()
        {
            return $"{Name} {Brand} {Size} {Color}";
        }
    }
}

