using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişNesneleri
{
    public class Kasa:Konum
    {
        public event EventHandler KasayaSiparişGeldi;

        public KasaÇalışanı çalışan { get; set; }
        public Sipariş sipariş { get { return çalışan.sipariş; } }

        public override void ÇalışanEkle(Çalışan çalışan)
        {
            if (this.çalışan != null)
                throw new Exception("Bu kasada zaten çalışan var.");

            this.çalışan = new KasaÇalışanı(çalışan,this);
            this.çalışan.SiparişGeldi += Çalışan_SiparişGeldi;  
        }

        private void Çalışan_SiparişGeldi(object sender, EventArgs e)
        {
            if (KasayaSiparişGeldi != null)
                KasayaSiparişGeldi(this, null);            
        }
    }
}
