using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety: tip güvenliği
            // Do not repeat yourself: kendini tekrarlama
            //değer tutucu (alias): kategoriEtiketi bununla tekrarlanan değerlere kodun her yerinde ulaşılır. 

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmısMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            //sart blokları
            //if iki kere tab a basılınca şart bloğu otomatik oluşur.

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }




            if (sistemeGirisYapmısMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
