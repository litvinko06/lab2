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