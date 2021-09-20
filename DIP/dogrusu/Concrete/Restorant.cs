using DIP.dogrusu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.dogrusu.Concrete
{
    public class Restorant
    {
        private List<IYemek> _yemekler;
        public Restorant(List<IYemek> yemekler)
        {
            _yemekler = yemekler;
        }

        public void YemekYap()
        {
            _yemekler.ForEach(x => x.Pisir());
        }
    }
}
