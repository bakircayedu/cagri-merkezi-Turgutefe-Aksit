using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri_Merkezi
{
    public class Cagri
    {
        public string Not { get; set; }
        public MusteriTemsilci musteriTemsilci { get; set; }
        public Musteri musteri { get; set; }
        public DateTime zamanBaslangic { get; set; }
        public DateTime zamanBitis { get; set; }
    }
}
