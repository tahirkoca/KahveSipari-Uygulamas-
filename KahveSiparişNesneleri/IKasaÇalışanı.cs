using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişNesneleri
{
    public interface IKasaÇalışanı
    {
        event EventHandler SiparişGeldi;

        void SiparişAl(Sipariş sipariş);
        Sipariş SiparişVer(Çalışan çalışan);
    }
}
