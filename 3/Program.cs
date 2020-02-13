using System;
using _2;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "value 1");
            Console.WriteLine(myDictionary[1]);

            myDictionary.Add(2, "value 2");
            Console.WriteLine(myDictionary[2]);

            Console.WriteLine("Now in the dictionary are " + myDictionary.Count + " items");
            myDictionary.RemoveAt(1);
            Console.WriteLine("Now in the dictionary are " + myDictionary.Count + " items");
        }
    }
    public class MyDictionary<TKey, TValue>
    {
        MyList<TKey> keys;
        MyList<TValue> values;
        int count = 0;
        public int Count { get => count; }
        public MyDictionary()
        {
            keys = new MyList<TKey>();
            values = new MyList<TValue>();
        }
        public TValue this[TKey index]
        {
            get
            {
                for (int i = 0; i < keys.Count; i++)
                {
                    if (keys[i].Equals(index))
                        return values[i];
                }
                throw new Exception("There is not inputed key in the dictionary");
            }
            set
            {
                for (int i = 0; i < keys.Count; i++)
                {
                    if (keys[i].Equals(index))
                        throw new Exception("The key has already existed in the dictionary");
                }
                keys.Add(index);
                count++;
            }
        }
        public void Add(TKey key, TValue value)
        {
            for (int i = 0; i < keys.Count; i++)
            {
                if (keys[i].Equals(key))
                {
                    Console.WriteLine("The key has already existed in the dictionary");
                    break;
                }
                keys.Add(key);
                values.Add(value);
                count++;
                return;
            }
            keys.Add(key);
            values.Add(value);
            count++;
        }
        public void RemoveAt(int index)
        {
            keys.Remove(index);
            values.Remove(index);
            count--;
        }
        public MyList<TKey> Keys
        {        
          get=> this.keys;
        }
        public MyList<TValue> Values
        {
            get => this.values;
        }
    }
}
