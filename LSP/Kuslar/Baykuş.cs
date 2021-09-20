using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Kuslar
{
    public class Baykuş : IKus
    {
        public bool Uc()
        {
            Console.WriteLine("baykus uctu");
            return true;
        }

        public bool Yuru()
        {
            Console.WriteLine("baykus yurudu");
            return true;
        }
    }
}
