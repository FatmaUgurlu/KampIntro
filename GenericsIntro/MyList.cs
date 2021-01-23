using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>                        //MyList imde T ile çalışıcam.T yerine istenilen herşey yazılabilir. tip vererek aşağıyı ona göre yapılandırır.
    {
        T[] items;                         //global alanda T türünde array oluşturulur
                                           //constructor => ctor iki kere tab yapılınca constructor oluşur. class ile aynı isimli olursa ordan onun constructorolduğunu gösterir.
        public MyList()                    //bir class new lendiği zaman constructor oluşur.
        {
            items = new T[0];
        }
        public void Add(T item)           //item=eleman
        {
            T[] tempArray = items;        //temparray= geçici dizi ye items daki elemanlar emanet edilir. new yapılınca önceki elemanlar uçmasın diye başkasına tutturulur.
            items = new T[items.Length + 1];           //liste elemanını 1 artırmak için items.lenght+1 yapılır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];              //emanet edilen items değerleri temparrayden geri alınır.
            }

            items[items.Length - 1] = item;          // dizinin kaç elemenalı olduğunu verir.
        }
    }
}
