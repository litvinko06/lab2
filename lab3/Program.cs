using System;
using System.Collections.Generic;
using System.Linq;

class Program_Main
{
    static void Main()
    {
        Repository<int> myCode = new Repository<int>();
        var commits = myCode.GetCommit();
        Random rnd = new Random();
        int number = 0;

        for (int i = 0; i < 10; i++)
        {
            number = rnd.Next(1, 21);
            myCode.Add(number);
        }

        Console.WriteLine("List:");
        foreach (var commit in commits)
        {
            Console.WriteLine(commit);
        }
        Console.WriteLine("");

        myCode.Delete(number);
        Console.WriteLine("List without last element:");
        foreach (var commit in commits)
        {
            Console.WriteLine(commit);
        }
        Console.WriteLine("");

        List<int> evenCommits = commits.FindAll(x => x % 2 == 0);
        Console.WriteLine("Even numbers in List:");
        foreach (int evencommit in evenCommits)
        {
            Console.WriteLine(evencommit);
        }
        Console.WriteLine("");
    }
}
