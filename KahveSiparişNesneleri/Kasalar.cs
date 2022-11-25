using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişNesneleri
{
    public class Kasalar:ICollection<Kasa>
    {
        private const int MAKSIMUM_KASA_SAYISI=3;
        private HashSet<Kasa> _kasalar;

        public int Count => ((ICollection<Kasa>)_kasalar).Count;

        public bool IsReadOnly => ((ICollection<Kasa>)_kasalar).IsReadOnly;

        public void Add(Kasa item)
        {
            if (_kasalar.Count == MAKSIMUM_KASA_SAYISI)
                throw new Exception("Daha fazla kasa ekleyemezsiniz");
            ((ICollection<Kasa>)_kasalar).Add(item);
        }

        public void Clear()
        {
            ((ICollection<Kasa>)_kasalar).Clear();
        }

        public bool Contains(Kasa item)
        {
            return ((ICollection<Kasa>)_kasalar).Contains(item);
        }

        public void CopyTo(Kasa[] array, int arrayIndex)
        {
            ((ICollection<Kasa>)_kasalar).CopyTo(array, arrayIndex);
        }

        public IEnumerator<Kasa> GetEnumerator()
        {
            return ((IEnumerable<Kasa>)_kasalar).GetEnumerator();
        }

        public bool Remove(Kasa item)
        {
            return ((ICollection<Kasa>)_kasalar).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_kasalar).GetEnumerator();
        }
        public Kasalar()
        {
            _kasalar = new HashSet<Kasa>();
        }
    }
}
