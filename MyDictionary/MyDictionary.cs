using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MyDictionary<TKey, TValue>
    {
        public TKey[] tkeys;
        public TValue[] tvalues;


        public MyDictionary() //constructor
        {
            tkeys = new TKey[0];
            tvalues = new TValue[0];

        }
        public void Add(TKey key, TValue value) //Eleman ekleme
        {
            TKey[] TempKeys = tkeys;
            TValue[] TempValues = tvalues;

            tkeys = new TKey[tkeys.Length + 1];
            for (int i = 0; i < TempKeys.Length; i++)
            {
                tkeys[i] = TempKeys[i];
            }
            tkeys[tkeys.Length - 1] = key;

            tvalues = new TValue[tvalues.Length + 1];
            for (int i = 0; i < TempValues.Length; i++)
            {
                tvalues[i] = TempValues[i];
            }
            tvalues[tvalues.Length - 1] = value;
        }

        public TKey[] Tkeys
        {
            get { return tkeys; }
        }

        public TValue[] Tvalues
        {
            get { return tvalues; }
        }

    }

}