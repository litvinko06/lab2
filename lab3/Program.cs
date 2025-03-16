using System;
using System.Collections.Generic;
using System.Linq;

class Program_Main
{
    static void Main()
    {
    Repository<string> myCode = new Repository<string>();
    myCode.Commit("test");
    myCode.Commit("test", "test: the sequel");
    }
}


// Це для тестування та розуміння як працює, потім приберемо
/*public class Calculator<T>
{
    public static bool AreEqual(T value1, T value2)
    {
        return value1.Equals(value2);
    }
}

class Geeks
{

    public static void Main(String[] args)
    {
        // Creating a List of integers
        List<int> l = new List<int>();

        // Adding elements to the List one by one
        l.Add(1);
        l.Add(2);
        l.Add(3);
        l.Add(4);
        l.Add(5);
        l.Add(6);
        l.Add(7);
        l.Add(8);
        l.Add(9);

        // Printing the Capacity and Count of l
        Console.WriteLine("Capacity: " + l.Capacity);
        Console.WriteLine("Count: " + l.Count);

        bool intEqual = Calculator<int>.AreEqual(4, 4);
        bool strEqual = Calculator<string>.AreEqual("Interview", "Happy");

        Console.WriteLine(intEqual);
        Console.WriteLine(strEqual);
    }
}*/
