using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class TurkKahvesi : GoodCoffee
    {
        public override double getTotalPrice(int adet)
        {
            return adet * 20;
        }
    }
}
