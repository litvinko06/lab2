class Person
{
    protected string phoneNumber = "+380-XX-XXX-XX-XX";
    protected string personName = "Alex K. O.";

    public virtual void GetInfo()
    {
        Console.WriteLine($"Name: {personName}");
        Console.WriteLine($"Number: {phoneNumber}");
    }
}

class Deanery : Person
{
    public string id = "M2NSB5I24GSG";

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Student ID: {id}");
    }
}