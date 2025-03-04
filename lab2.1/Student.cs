public class Student : IUsesTransport
{
    public string Name { get; set; }
    public Transport Transport { get; set; }

    public Student(string name, Transport transport)
    {
        Name = name;
        Transport = transport;
    }

    public void UseTransport()
    {
        Console.WriteLine($"{Name} користується транспортом {Transport.Model}.");
        Transport.Move();
    }
}