using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Fatma";
            musteri1.Soyadi = "Uğurlu";
            musteri1.TcNo = "22222222222";


            //Kodlama.io


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "2345";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123456789";



            Musteri musteri3 = new GercekMusteri();    //new bellekteki referans numarasını tutar.
            Musteri musteri4 = new TuzelMusteri();     //Musteri hem gerçek hem de tüzel müşterinin bilgilerini tutar.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);







            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Fatma";
            //musteri1.Soyadi = "Uğurlu";
            //musteri1.Id = 1;
            //musteri1.TcNo = "22222222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";

            //Gerçek - Tüzel=ikisi de müşteridir fakat birbirine benziyor diye birbiri yerine kullanılamaz. bireysel müşteriye şirket adı tanımlanamaz. tanımlanırsa soyutlama hatası yapılır.
            //SOLID
        }
    }
}
