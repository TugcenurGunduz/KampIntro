using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList() //class ı newlersek otomatik çalışır.
        {
            items = new T[0];//0 elemanlı bir array
        }
        public void Add(T item) //item=eleman //buradan diziye eleman ekleyebilirim
        {
            T[] tempArray = items; //geçici dizinin referansı, items'ın referansı.//diziye eleman ekleyebilmek için önce eleman sayısını 1 arttırmalıyız ->
            items = new T[items.Length + 1]; //items.length dizinin eleman sayısıdır. items.length+1 dizinin eleman sayısını 1 arttırır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; } //eleman sayısını verir
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
