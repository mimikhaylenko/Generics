using System;
using _2;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> my = new MyList<string>();

            my.Add("the first");
            my.Add("the second");
            my.Add("the third");

            string[] arr = my.GetArray();
            foreach (string item in arr)
                Console.Write($"{item}\n");
        }
    }
    static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] arr = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
                arr[i] = list[i];
            return arr;
        }
    }
}
