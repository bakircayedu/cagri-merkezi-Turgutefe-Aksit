using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri_Merkezi
{
    public enum ENDurum
    {
        Mesgul,
        Musait
    }
    public class MusteriTemsilci : Birey
    {
        public int TemsilciNumarasi { get; set; }
        public ENDurum Durum { get; set; }
        public Musteri musteri { get; set; }
        public MusteriTemsilci()
        {
            Durum = ENDurum.Musait;
        }
    }
}
