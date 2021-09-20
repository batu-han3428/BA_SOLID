using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Bad
{
    public class BadRestorant
    {
        //Buradaki değişkenler direkt başka sınıflara bağlıdır.
        //DIP'e göre classlar birbirine direkt bağlı olmamalıdır.
        
        private BadTavuk tavuk = new BadTavuk();
        private BadBalik balik = new BadBalik();
    
        public void YemekYap()
        {
            balik.BalikPisir();
            tavuk.TavukPisir();
        }
    }
}
