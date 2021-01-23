using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    { 
        // Method injection=  metodun kullanacağı kredi ve log injection yapılıyor.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService )    //IKrediManager bütün kredilerin referanslarını tuttuğu için ayrı ayrı kredi değerlendirmesi için bilgi tutmaya gerek yoktur.
        {
            //başvuran bilgilerini değerlendirme

            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)   //bana kredi listesi ver fakat türü IKrediManager olsun.
        {
            foreach (var kredi in krediler)     //listedeki her bir krediye giderek hesaplama yap.
            {
                kredi.Hesapla();
            }
        }
    }
}
