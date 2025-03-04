class StudentAlex : Person
{
    public virtual void Info(string name = "Alex")
    {
        Console.WriteLine($"My name is {name}, I'm a student of NTU \"Igor Sikorsky Kyiv Polytechnic Institute\".");
    }

    public static void Scholarship(int amount = 2000)
    {
        Console.WriteLine($"Basic scholarship is {amount}");
    }
    public static void Scholarship(string result, int amount = 3000)
    {
        Console.WriteLine($"Greater scholarship is {amount}");
    }

    public string id = "M2NSB5I24GSG";

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Student ID: {id}");
    }
}