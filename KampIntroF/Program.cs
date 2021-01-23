using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";            //kurs claasında bulunan kurs1 deki tiplerin değerlerini atama yapılır.
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";            //kurs claasında bulunan kurs1 deki tiplerin değerlerini atama yapılır.
            kurs2.Egitmen = "Fatma Uğurlu";
            kurs2.İzlenmeOrani = 76;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";            //kurs claasında bulunan kurs1 deki tiplerin değerlerini atama yapılır.
            kurs3.Egitmen = "berkay Bilgin";
            kurs3.İzlenmeOrani = 80;

            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);  // burda ilk kursun adını ve eğitmenini araya : koyarak yazar. 

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };  //string yerine artık kurs adı içerisinde listeleme yapılarak dizi oluşturulabilir.

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);  // çalıştırıldığında burda ilk kursun adını ve eğitmenini araya : koyarak yazar. sonra kurs2 deki ve kurs3 teki bilgileri ekrana sırayla yazar. 
            }
        }
    }

    class Kurs              //prop yazıp tab iki kere basınlınca public yapısı cıkar. kurs class ı içinde tipler tanımlanır.
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int İzlenmeOrani { get; set; }
    }
}
