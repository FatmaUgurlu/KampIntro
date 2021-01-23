using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Fatma", "Emre", "Ayşe", "Eşref" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);     //eleman sayısı dışında 5. elemanı okuyamaz. 
            //                                   //new yazıldığında yeni referans değeri tanımlanır.
            //isimler = new string[5];           //new yazıldığı için yeni bir dizi oluşur. bu nedenle ilk dizidekiler yazılır  sonra 2.dizideki ilker de yazar fakar sonrasında 0. eleman yazılmaz. 
            //isimler[4] = "ilker";              //çünkü bu dizide 0. eleman yoktur.
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> { "Fatma", "Emre", "Ayşe", "Eşref" };  //listeye stringler yerleştirilir.
                                                                                            //isimler2.Add("Maşuk");       //şeklinde de eleman eklenebilir.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");                    //listeye değer ekler.
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }  //koleksiyonlarda arrayler gibi değerleri kaybetmemizi engelleyici alt yapı vardır.
    }      //class lar yeşil renkli yazar. List de bir class tır.
}
