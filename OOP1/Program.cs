using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product {Id=2, CategoryId=5, UnitInStock= 5, ProductName= "Kalem", UnitPrice= 35};  // ürüne ait özellikler bu şekilde de yazılabilir. 

            //PascalCase = sınıfın isminin baş harfi büyük yazılır.
            //camelCase  = özelliklerin ilk harfi küçük ikinci adı büyük harfle yazılır.
            //case sensitive = büyük küçük harf duyarlılığı

            ProductManager productManager = new ProductManager();         //stack te oluşturduk = heap oluşturduk
            productManager.Add(product1);                //() içerisine parametre yazılarak ne ekleneceği yazılır. product1 in tüm özellikleri ProductManager da gösterir.
            Console.WriteLine(product1.ProductName);





        }
    }
}
