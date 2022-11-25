using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişNesneleri
{
    public interface IÜrünHazırlayan
    {
        Sipariş hazırlanacakSipariş { get; set; }
        void SiparişHazırla();
    }
}
