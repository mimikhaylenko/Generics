using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = MyClass<int>.FacrotyMethod();
            string s = MyClass<string>.FacrotyMethod();
            Console.WriteLine(s);
        }

        public class MyClass<T>
        {
            public static T FacrotyMethod()
            {
                T value = default(T);
                return value;
            }
        }
    }
}
