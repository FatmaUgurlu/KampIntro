using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation ile Product classında bilgiler çekilir.
        public void Add(Product product)         // Product class ından product türünde birşeyler ver.
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }













        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}  //burda topla da sayi1 ve sayi2 topalnır. return ile bu topalm değerini sonra başka işlem yapmak için kullanırız. bu nedenle int  kullanır. programın akışındaki sayısal değer kullanılır.
        //   // bu sayısal değeri kullanmak, listelemek, bir sayı ile çarpmak için burada return yazılır. ve ekrana console.writeline ile yazılır.
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //} //topla2 sayi1 ile sayi2 yi topluyor. toplam sonucu ortaya çıkan sayı değerini daha sonra kullanılmayacaksa void kullanılır. burda return kullanılmaz.
    }
}
