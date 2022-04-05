using System;

namespace CSharpGenericsBasics {

    public class Program {

        static void Main(string[] args) {

            int x = 5;
            int y = 7;

            swap<int>(ref x, ref y);

            Console.WriteLine($"\nValue of x is {x} and the value of y is {y}");

            Person p1 = new Person("Werner", 42);
            Person p2 = new Person("Jeanette", 37);

            swap<Person>(ref p1, ref p2);

            Console.WriteLine($"The value of person 1 is {p1.Name} and the value of person 2 is {p2.Name}");

            Console.ReadLine();

        }

        public static void swap<T> (ref T obj1, ref T obj2) {
            T temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }
    }
}