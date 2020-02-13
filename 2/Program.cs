using System;
using System.Collections;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> my = new MyList<string>();

            my.Add("the first");
            my.Add("the second");
            my.Add("the third");

            Console.WriteLine(my[2]);
            Console.WriteLine(my[1]);
            Console.WriteLine(my[0]);
            Console.WriteLine("Amount of items: " + my.Count);
            my.Remove(0);
            Console.WriteLine(my[1]);
            Console.WriteLine(my[0]);
            Console.WriteLine("Amount of items: " + my.Count);
        }
    }
    public class Node<T>
    {
        T item;
        public T Item { get { return item; } set { item = value; } }
        public Node<T> Next { get; set; }

    }
    public class MyList<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;
        public virtual int Count { get => count; }
        int index = -1;

        public virtual void Add(T value)
        {
            Node<T> node = new Node<T>();
            node.Item = value;
            if (head == null)
                head = node;
            else tail.Next = node;
            tail = node;
            count++;
        }
        public virtual void Remove(int index)
        {
            Node<T> node = new Node<T>();
            int counter = 0;
            node = head;
            if (count < index)
                return;
            else if (index == 0)
            {
                if (node.Next == null)
                {
                    tail = null;
                    head = null;
                }
                else
                {
                    head = node.Next;
                    tail = head.Next;
                }
                count--;
            }
            else
            {
                while (node.Next.Next != null)
                {
                    node = node.Next;
                    counter++;
                    if (counter == index)
                    {
                        node.Item = node.Next.Item;
                    }
                }

                node.Next = null;
                count--;
            }
        }

        public T this[int index]
        {
            get
            {
                T temp = default(T);
                int counter = 0;
                Node<T> current = head;
                temp = current.Item;
                while (current != null)
                {
                    if (counter == index)
                        return temp;
                    else
                    {
                        counter++;
                        current = current.Next;
                        temp = current.Item;
                    }
                }
                Console.WriteLine("This index doesn't exist");
                return default(T);
            }
        }
    }
}
