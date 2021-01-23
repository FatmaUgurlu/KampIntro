using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate = tüzel müşteri
    //miras = inheritance => müşteride olan özellikler artık gerçekte ve tüzelde de vardır.
    class TuzelMusteri:Musteri
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    }
}
