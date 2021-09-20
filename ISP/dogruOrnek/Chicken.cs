using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.dogruOrnek
{
    public class Chicken : IWalk
    {
        public bool Walk()
        {
            Console.WriteLine("Chicken walking...");
            return true;
        }
    }
}
