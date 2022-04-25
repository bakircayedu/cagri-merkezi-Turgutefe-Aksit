using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri_Merkezi
{
    public enum Tur
    {
        Bireysel,
        Ticari
    }
    public class Birey
    {
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public Tur tur { get; set; }
    }
}
