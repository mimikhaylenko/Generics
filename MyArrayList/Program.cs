using System;
using _2;

namespace MyArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList arrayList = new MyArrayList();
            arrayList.Add(5);
            Console.WriteLine("was added " + arrayList[0]);
            arrayList.Add("str");
            Console.WriteLine("was added " + arrayList[1]);
            Console.WriteLine("Count of items: " + arrayList.Count);

            arrayList.Clear();
            Console.WriteLine("The list was cleared. Count of items: " + arrayList.Count);
            Console.Read();
        }
    }
    class MyArrayList 
    {
        MyList<object> list;
        public int Count { get => list.Count; }
        public MyArrayList()
        {
            list = new MyList<object>();
        }
        public void Clear()
        {
            for (int i = Count; i > 0; i--)
                list.Remove(0);
        }
        public void Add(object value)
        {
            list.Add(value);
        }
        public void Remove(object value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (value == list[i])
                    list.Remove(i);
            }    
        }
        public int IndexOf(object value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (value == list[i])
                    return i;
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            list.Remove(index);
        }
        public object this[int index]
        {
            get => list[index]; 
        }
    
    }
}
