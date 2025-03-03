class Speciality // Динамічний
{
    public virtual void Info(string name = "126")
    {
        Console.WriteLine($"And number of my speciality is {name}.");
    }
}

class Group : Speciality
{
    public override void Info(string name = "IS-42")
    {
        Console.WriteLine($"Mine group is {name}.");
    }
}

class Student : Group
{
    public override void Info(string name = "Alex")
    {
        Console.WriteLine($"My name is {name}, I'm a student of NTU \"Igor Sikorsky Kyiv Polytechnic Institute\".");
    }

    // Статичний
    public static void Scholarship(int amount = 2000)
    {
        Console.WriteLine($"Basic scholarship is {amount}");
    }
    public static void Scholarship(string result, int amount = 3000)
    {
        Console.WriteLine($"Greater scholarship is {amount}");
    }
}

class Program
{
    static void Main()
    {
        Speciality mySpeciality = new Speciality();
        Group myGroup = new Group();
        Student myInfo = new Student();

        myInfo.Info();
        myGroup.Info();
        mySpeciality.Info();

        Student.Scholarship();
        Student.Scholarship("Great");

        Deanery thisDeanery = new Deanery();

        thisDeanery.GetInfo();
    }
}