using System;
using Microsoft.Extensions.DependencyInjection;

namespace DIP_IOC
{
    class Program
    {
        static IServiceCollection services = new ServiceCollection();
        static void Main(string[] args)
        {
            //IPersonelService service = new PersonelService();

            ServiceLifetime();

            //Concrete olarak kullanıldı
            Sekreter ayşe = new Sekreter();
            ayşe.AdSoyad = "Ayşe yılmaz";

            //fatma Ikisiden bağlı
            IPersonel fatma = new Sekreter();
            fatma.AdSoyad = "Fatma yapıcı";

        
            //service.ekle(ayşe);
            //service.ekle(fatma);
        }

        private static void ServiceLifetime()
        {
            
            services.AddSingleton<IPersonelService>();
            services.BuildServiceProvider();
        }
    }
}
