using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişNesneleri
{
    public class Şube
    {

        public Çalışanlar çalışanlarHavuzu { get; set; }
        public Kasalar kasalar { get; set; }
        public ÜrünHazırlama ürünHazırlama { get; set; }

        public int maksimumÇalışanSayısı {
            get { return çalışanlarHavuzu.maksimumÇalışanSayısı; }  // UI yazılımcısı için kolaylık olsun diye eklendi
        }

        public int maksimumÜrünHazırlayanSayısı {
            get { return ürünHazırlama.ürünHazırlayanlar.maksimumÇalışanSayısı; } // UI yazılımcısı için kolaylık olsun diye eklendi
        }

        public void ÇalışanaKonumAta(Çalışan çalışan, Konum konum) {
            try
            {
                konum.ÇalışanEkle(çalışan);
                çalışanlarHavuzu.Remove(çalışan);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void YeniKasaAç() {
            Kasa yeni = new Kasa();
            kasalar.Add(yeni);
            yeni.KasayaSiparişGeldi += OnKasayaSiparişGeldi;
        }

        private void OnKasayaSiparişGeldi(object sender, EventArgs e)
        {
            Kasa gelenKasa = (Kasa)sender; 
            //Boşta Çalışan bul
            Çalışan boşta= çalışanlarHavuzu.SıradakiniGetir();
            ÜrünHazırlayan ürünHazırlayan = new ÜrünHazırlayan(boşta, ürünHazırlama);
            ürünHazırlayan.hazırlanacakSipariş = gelenKasa.sipariş;
            ürünHazırlayan.SiparişHazırla();
            
        }

        public Şube(int maksimumÇalışanSayısı,int maksimumÜrünHazırlayanSayısı)
        {
            çalışanlarHavuzu = new Çalışanlar(maksimumÇalışanSayısı);
            kasalar = new Kasalar();
            ürünHazırlama = new ÜrünHazırlama(maksimumÜrünHazırlayanSayısı);
        }
    }
}
