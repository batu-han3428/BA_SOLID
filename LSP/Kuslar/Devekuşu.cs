using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Kuslar
{
    public class Devekuşu : IKus
    {
        public bool Uc()
        {
            return false;
        }

        public bool Yuru()
        {
            Console.WriteLine("devekuşu yürüdü");
            return true;
        }
    }
}
