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
