using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_IOC
{
    public interface IKisi
    {
        int Id { get; set; }
        string AdSoyad { get; set; }
        string Tc { get; set; }
        string Gsm { get; set; }
        DateTime CreateDate { get; set; }
    }
}
