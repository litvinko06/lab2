using System;
using System.Collections.Generic;
using System.Linq;

class Program_Main
{
    static void Main()
    {
        Random rnd = new Random();
        Repository<int> myCode = new Repository<int>();
        var commits = myCode.GetCommit();

        /*myCode.Commit("test");
        foreach (var commit in commits)
        {
            Console.WriteLine(commit);
        }
        myCode.Commit("test", "test: the sequel");
        foreach (var commit in commits)
        {
            Console.WriteLine(commit);
        }*/

        int number = 0;
        for (int i = 0; i < 10; i++)
        {
            number = rnd.Next(1, 21);
            myCode.Commit(number);
        }
        Console.WriteLine("");
        foreach (int commit in commits)
        {
            Console.WriteLine(commit);
        }
        Console.WriteLine("");

        myCode.Commit(number, rnd.Next(1, 21));
        Console.WriteLine("");
        foreach (int commit in commits)
        {
            Console.WriteLine(commit);
        }
        Console.WriteLine("");

        List<int> evenCommits = commits.FindAll(x => x % 2 == 0);
        foreach (int evencommit in evenCommits)
        {
            Console.WriteLine(evencommit);
        }
        Console.WriteLine("");

        int n = 5;
        int j = 0;
        foreach (int commit in commits)
        {
            if (j == n)
            {
                Console.WriteLine(commit);
            }
            j++;
        }
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

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);

        foreach (var item in evenNumbers)
        {
            Console.WriteLine(item);
        }
    }
}*/