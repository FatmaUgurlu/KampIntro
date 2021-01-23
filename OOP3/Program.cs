using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {  //interface lerde referans bilgileri tutar.
        static void Main(string[] args)     //başvuru görüntü ekranıdır. hangi kredi hesaplanacaksa onu seçerek hesaplama yapılır.
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);  //new FileLoggerServise olarak da yazılabilir.

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasıtKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
