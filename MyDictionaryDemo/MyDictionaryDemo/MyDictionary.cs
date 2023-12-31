﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryDemo
{
    internal class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;

        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tempKeys = keys;
            Tvalue[] tempValues = values;

            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[keys.Length - 1] = value;
        }

        public Tkey[] Keys 
        { 
            get { return keys; } 
        }

        public Tvalue[] Values 
        {
            get {  return values; } 
        }

    }
}
