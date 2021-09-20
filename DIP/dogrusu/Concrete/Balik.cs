using DIP.dogrusu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.dogrusu.Concrete
{
    public class Balik : IYemek
    {
        public void Pisir()
        {
            Console.WriteLine("Balık pişti.");
        }
    }
}
