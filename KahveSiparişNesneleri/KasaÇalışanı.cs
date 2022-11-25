using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişNesneleri
{
    public class KasaÇalışanı : IKasaÇalışanı
    {
        //Sipariş geldi Event için
       // public delegate void OnSiparişGeldiHandler(object sender, EventArgs args);
        public event EventHandler SiparişGeldi;
        public Çalışan çalışan;
        public Kasa kasa { get; set; }

        private Sipariş _sipariş;
        public Sipariş sipariş {
            get { return _sipariş; }
            private set {
                if (value == null) {
                    _sipariş = null;

                }
                else
                {
                    _sipariş = value;
                    if (SiparişGeldi != null)
                        SiparişGeldi(this, null);
                    else
                        throw new Exception("Sipariş Alamıyorum");
                }
            } 
        }

        public KasaÇalışanı(Çalışan çalışan,Kasa kasa):base()
        {
            this.çalışan = çalışan;
            this.kasa = kasa;
            this.çalışan.Konumum = kasa;
        }

        public void SiparişAl(Sipariş sipariş)
        {
            this.sipariş = sipariş;    
            //Çalışanlara Erişim Yok Byu yüzden SiparişimVarDiyeBilgiVer

        }

        public Sipariş SiparişVer(Çalışan çalışan)
        {
            throw new NotImplementedException();
        }
    }
}
