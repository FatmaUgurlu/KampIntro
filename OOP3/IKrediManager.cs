using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{      //interfaceleri birbirinin alternatifi olan kod içerikleri farklı olan içerikleri tutmak için kullanırız.
       //loglama kim ne zaman hangi operasyonu çağırdı?
       //log lar veritabanı , sms olarak atılabilir, dosyada tutulabilir,mail göndermek loglamanın alternatifleridir.

    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
        
    }
}
