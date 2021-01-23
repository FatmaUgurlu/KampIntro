using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet= hazır kodlarda kare çıkmasıdır.
    //CRUD = CREAT, READ, UPDATE, DELETE operasyonlar yapılır. 
    class Product      //entity (varlık)
    {
        public int Id { get; set; }                            //ana anahtar yani primary key
        public int CategoryId { get; set; }                    //referans anahtarlar kod okunurluğundan dolayı 2. satıra yazılır. foreign key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }


        



    }
}
