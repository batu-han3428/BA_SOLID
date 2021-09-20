using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Bad
{
    public class BadChicken : IBird
    {
        public bool Fly()
        {
            return false;
        }

        public bool Walk()
        {
            Console.WriteLine("Chicken walking...");
            return true;
        }
    }
}
