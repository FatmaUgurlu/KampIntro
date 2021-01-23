using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        //bir nesenyi bir değeri kullanmak zorunda değilmiş gibi ise o zaman orada soyutlama hatası yapılır.
        //bu iki özellik miras yoluyla tüzel ve gerçek müşteriye aittir.
    }
}
