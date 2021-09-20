using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_IOC
{
    public class Sekreter : IPersonel,ITelefonaBakabilir
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Tc { get; set; }
        public string Gsm { get; set; }
        public DateTime CreateDate { get; set; }
        public int personelNo { get; set; }

        public void telefonaBak() {
            Console.WriteLine("Telefona bakıldı.");
        }
    }
}
