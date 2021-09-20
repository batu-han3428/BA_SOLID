using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Kuslar.dogruOrnek
{
    public class Penguen : IYuruyebilir, IYuzebilir
    {
        public bool Yuru()
        {
            throw new NotImplementedException();
        }

        public bool Yuz()
        {
            throw new NotImplementedException();
        }
    }
}
