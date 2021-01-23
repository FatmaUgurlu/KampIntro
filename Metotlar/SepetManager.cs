using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //sepete ürün ekleme yapmak için public void kullanılır.
        public void Ekle(Urun urun)       //kodun yapacağı iş süslü parantez içine yazılır.
        {                        //eklenmek istenilen parametrelerle () içinde yazılır.
            Console.WriteLine("Sepete eklendi : " + urun.Adi);   // sepete eklendi : ürün adı yazılı olur.

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)  //ayrı ayrı yazılınca class değil fakat 11.satırdaki kapsülleme yapılarak bir class oluşturulur.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }

    }
}
