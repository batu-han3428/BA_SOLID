using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.alisveriIslemleri
{
    public class alisveris
    {
        public double urunFiyati { get; set; }

        public bool LimitYeterlimi()
        {
            return true;
        } 
        
        public bool AlisverisiTamamla()
        {
            return true;
        }
    }
}
