using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Kuslar
{
    public class Serce : IKus
    {
        public bool Uc()
        {
            Console.WriteLine("serçe uçtu");
            return true;
        }

        public bool Yuru()
        {
            Console.WriteLine("yürüdü");
            return true;
        }
    }
}
