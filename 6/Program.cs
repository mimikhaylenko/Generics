using System;
using _3;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Remove("23");
            myDictionary.Add("23", "32");
            myDictionary.Remove("23");
       
        }
    }
     static class MyDictionaryExtensions 
    {
        public static void Remove<TKey, TValue>(this MyDictionary<TKey, TValue> dictionary, TKey key)
        {
            for (int i = 0;i<dictionary.Count;i++)
            {
                if (dictionary.Keys[i].Equals(key))
                {
                    dictionary.RemoveAt(i);
                }
            }
        }
    }
}
