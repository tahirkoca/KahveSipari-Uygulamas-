using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişNesneleri
{
    public class Çalışanlar:ICollection<Çalışan>
    {
        private int _maksimumÇalışanSayısı;
        public int maksimumÇalışanSayısı {
            get { return _maksimumÇalışanSayısı; }
            set {
                if (value < 4)
                    throw new Exception("Çalışan sayısı en az dört olabilir");
                if (value > 5)
                    throw new Exception("Çalışan sayısı en fazla beş olabilir");
                _maksimumÇalışanSayısı = value;
            } 
        }

        public int Count => ((ICollection<Çalışan>)_çalışanlar).Count;

        public bool IsReadOnly => ((ICollection<Çalışan>)_çalışanlar).IsReadOnly;

        private List<Çalışan> _çalışanlar;



        public Çalışanlar(int maksimumÇalışanSayısı)
        {
            this.maksimumÇalışanSayısı = maksimumÇalışanSayısı;
            _çalışanlar = new List<Çalışan>();
        }

        public void Add(Çalışan item)
        {
            if (_çalışanlar.Count == maksimumÇalışanSayısı)
                throw new Exception("Daha fazla çalışan ekleyemezsiniz");
            ((ICollection<Çalışan>)_çalışanlar).Add(item);
        }

        public void Clear()
        {
            ((ICollection<Çalışan>)_çalışanlar).Clear();
        }

        public bool Contains(Çalışan item)
        {
            return ((ICollection<Çalışan>)_çalışanlar).Contains(item);
        }

        public void CopyTo(Çalışan[] array, int arrayIndex)
        {
            ((ICollection<Çalışan>)_çalışanlar).CopyTo(array, arrayIndex);
        }

        public bool Remove(Çalışan item)
        {
            return ((ICollection<Çalışan>)_çalışanlar).Remove(item);
        }

        public IEnumerator<Çalışan> GetEnumerator()
        {
            return ((IEnumerable<Çalışan>)_çalışanlar).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_çalışanlar).GetEnumerator();
        }
        public Çalışan SıradakiniGetir() {
            if (_çalışanlar.Count == 0)
                throw new Exception("Boşta çalışan yok");
            Çalışan boş = _çalışanlar.First();
            _çalışanlar.Remove(boş);
            return boş;
        }
 
    }
}
