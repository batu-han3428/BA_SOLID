using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class BadCofee
    {
        public enum CoffeeType { 
            Latte,
            Expresso,
            TurkKahvesi,
            FiltreKahve
        }

        public decimal GetTotalPrice(int adet, CoffeeType coffeeType) {

            decimal totalPrice = 0;

            if (coffeeType == CoffeeType.Expresso)
            {
                totalPrice = adet * 11;
            }else if (coffeeType == CoffeeType.Latte)
            {
                totalPrice = adet * 15;
            }else if (coffeeType == CoffeeType.TurkKahvesi)
            {
                totalPrice = adet * 20;
            }

            return totalPrice;
        }
    }
}
