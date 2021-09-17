using OCP.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.concrete
{
    public class Latte : ICoffee
    {
        public decimal getTotalPrice(int adet)
        {
            return adet * 15;
        }
    }
}
