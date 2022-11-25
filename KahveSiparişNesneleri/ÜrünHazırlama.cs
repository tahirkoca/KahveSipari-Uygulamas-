using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişNesneleri
{
    public class ÜrünHazırlama:Konum
    {
        public Çalışanlar ürünHazırlayanlar { get; set; }
        
        public ÜrünHazırlama(int maksimumÇalışanSayısı)
        {
            ürünHazırlayanlar = new Çalışanlar(maksimumÇalışanSayısı);
        }

        public override void ÇalışanEkle(Çalışan çalışan)
        {
            this.ürünHazırlayanlar.Add(çalışan);
            çalışan.Konumum = this;            
        }
    }
}
