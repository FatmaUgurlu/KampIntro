using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //döngüler ile tekrar tekrar yazmak yerine bir dizi içerisine listelenir ve ordan istenilen veriye ulaşılır.
            //array = diziler => birden fazla string aynı anda tutmak için kullanılır. tek tek stringleri tanımlamak yerine bir dizi içine sıralanır ve ordan verilere ulaşılır.


            string[] kurslar = new string[] { "Yazılımcı geliştirici yetiştirme kampı", "Programlamaya başlangıç için temel kurs", "java", "Python" }; //birden fazla string tutar

            for (int i = 0; i < kurslar.Length; i++)  //0,1,2,3 değerleri için çalışır. length kaç tane eleman varsa o rakama kadar döndürür. i<4 te de döner fakat eleman eklenirse bu noktanın değişmesi gerekir.
            {
                Console.WriteLine(kurslar[i]);

            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)  //foreach =>dizi temelli yapıları tek tek dönmeye yarar. Kurslar içinde dolaşır ve tek tek çalışmasını sağlar.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");

            for (int i = 1; i < 10; i++)   //1den başlar ve ikinci kısım şart kısmıdır.
            {                              //aynı blok içinde 1den başlar 9a kadar değer döner
                Console.WriteLine("i");    //i=10 olunca değer dönmez ve döngüden çıkar.
            }                              //i=i+1 ile i++ aynı 2şer artır deseydi i=i+2 olur.
        }
    }
}
