using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Bad
{
    public class Hawk : IBird
    {
        public bool Fly()
        {
            Console.WriteLine("Hawk fly...");
            return true;
        }

        public bool Walk()
        {
            Console.WriteLine("Hawk walking...");
            return true;
        }
    }
}
