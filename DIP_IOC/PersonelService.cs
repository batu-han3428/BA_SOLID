using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_IOC
{
    public class PersonelService : IPersonelService
    {
        public void ekle(IPersonel kisi)
        {
            kisi.CreateDate = DateTime.Now;
            Console.WriteLine(kisi.AdSoyad+ " Eklendi:"+kisi.CreateDate);
        }

        public void guncelle(IPersonel kisi)
        {
           
            Console.WriteLine(kisi.AdSoyad + " Güncellendi:" + DateTime.Now);
        }

        public void sil(IPersonel kisi)
        {
            
            Console.WriteLine(kisi.AdSoyad + " Silindi:" + DateTime.Now);
        }
    }
}
