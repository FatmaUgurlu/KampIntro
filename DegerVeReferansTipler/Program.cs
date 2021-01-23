using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10; 
            int sayi2 = 30;
            sayi1 = sayi2;  //sayi2 değeri sayi1 değerine aktarılır ve sayi1 ın değeri artık 30 olur.
            sayi2 = 65;     //sayi2 nın değeri 65 yap

            //sayi1 kaç olur? cevap=30

            int[] sayilar1 = new int[] { 10, 20, 30 };        //sayilar1 stack olarak tanımlanır. new bellekten bir adres oluşturur.
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;   //sayilar1 ın referans numarası sayılar2 ın referans numarasına eşit oluyor ve artık sayılar2 nın adresını tutar.
            sayilar2[0] = 999;

            //sayilar1[0] =999 olur. en son sayilar2 nin 0. indisinde 999 vardır.

            //int,decimal,float,double,bool = değer tip
            //array,class,interface = referans tip

            //bellekte stack ve heap var.
            //değer tipler stack te tanımlanır. sayi1=10 (sayi1 in değeri 10 dur) sayi2=30 (sayi2 nin değeri 30)
            //referans tipler heapte tanımlanır. 


        }
    }
}
