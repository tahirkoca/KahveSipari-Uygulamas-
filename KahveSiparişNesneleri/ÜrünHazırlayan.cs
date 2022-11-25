using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişNesneleri
{
    public class ÜrünHazırlayan:IÜrünHazırlayan
    {
        public Çalışan çalışan { get; private set; }
        public ÜrünHazırlama ürünHazırlama { get; private set; }

        private Sipariş _sipariş;
        public Sipariş hazırlanacakSipariş {
            get { return _sipariş; }
            set { _sipariş = value;
                SiparişHazırla();
            } 
        }

        public ÜrünHazırlayan(Çalışan çalışan,ÜrünHazırlama ürünHazırlama)
        {
            this.çalışan = çalışan;
            this.ürünHazırlama = ürünHazırlama;
            this.çalışan.Konumum = ürünHazırlama;
        }

        public void SiparişHazırla()
        {
            throw new NotImplementedException();
        }
    }
}
