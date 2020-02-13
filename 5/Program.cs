using System;
using _2;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car<string> car = new Car<string>("Ford", 1980);
            Car<string> car1 = new Car<string>("Toyota", 1980);
            Car<string> car2 = new Car<string>("BMW", 1980);

            CarCollection<string> carCollection = new CarCollection<string>();
            carCollection.Add(car);
            carCollection.Add(car1);
            carCollection.Add(car2);
            Console.WriteLine(carCollection[1]);
            Console.WriteLine(carCollection.Count);
            carCollection.Clear();
            Console.WriteLine(carCollection.Count);
            Console.ReadLine();
        }
    }
    class Car<T>
    {
        T name;
        int year;
        public Car(T name, int year)
        {
            this.name = name;
            this.year = year;
        }
        public override string ToString()
        {
            return $"Car: {this.name} from {this.year}";
        }

    }
    class CarCollection<T>
    {
        MyList<Car<T>> Cars;
        public CarCollection()
        {
            Cars = new MyList<Car<T>>();
        }
        public int Count { get => Cars.Count; }
        public void Add(Car<T> car)
        {
            Cars.Add(car);
        }
        public object this[int index]
        {
            get => Cars[index];
        }
        public void Clear()
        {
            for (int i = Count; i > 0; i--)
                Cars.Remove(0);
        }
    }
}
