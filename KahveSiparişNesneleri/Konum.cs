using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişNesneleri
{
    public abstract class Konum
    {
        public abstract void ÇalışanEkle(Çalışan çalışan); //Farklı konumlar farklı olarak bu metodu implement edecek.
    }
}
