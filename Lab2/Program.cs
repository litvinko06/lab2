using System;


class Program
{
    static void Main()
    {
        Transport bus = new Bus("Mercedes Sprinter", 20);
        Student student = new Student("Андрій", bus);
        
        student.UseTransport();
    }
}