using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Kuslar.dogruOrnek
{
    public class Serce : IYuruyebilir, IUcabilir
    {
        public bool Uc()
        {
            throw new NotImplementedException();
        }

        public bool Yuru()
        {
            throw new NotImplementedException();
        }
    }
}
