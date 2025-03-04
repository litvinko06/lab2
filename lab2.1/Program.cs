using System;

class Program
{
    static void Main()
    {
        Transport bus = new Bus("Mercedes Sprinter", 20);
        Student student = new Student("Андрій", bus);

        student.UseTransport();

        Console.WriteLine("");

        Speciality mySpeciality = new Speciality();
        Group myGroup = new Group();
        StudentAlex myInfo = new StudentAlex();

        myInfo.Info();
        myGroup.Info();
        mySpeciality.Info();

        Console.WriteLine("");

        StudentAlex.Scholarship();
        StudentAlex.Scholarship("Great");

        StudentAlex myGetInfo = new StudentAlex();
        myGetInfo.GetInfo();
    }
}