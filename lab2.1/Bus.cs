public class Bus : Transport
{
    public Bus(string model, int capacity) : base(model, capacity) { }

    public override void Move()
    {
        Console.WriteLine($"Автобус {Model} рухається по маршруту з місткістю {Capacity} пасажирів.");
    }
}