using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "AMASYA ELMASI";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "AMASYA ELMASI";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe -> tip güvenliği

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urunAdi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("---------Metotlar----------");

            //instance - örnek
            //encapsulation (kapsülleme)

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);    //seperManager da ekle() içinde yapılan değişimi burda da uygulamak gerekir. çünkü parametre ister ve ürünleri gönderir.
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,9);
        }
    }
}


// metotlar tekrar tekrar kullanılmayı sağlar.
//dont repeat yourself -> DRY -> clean code (temiz kod) -> best practice (doğru uygulama tekniği) 
//