public abstract class Transport
{
    public string Model { get; set; }
    public int Capacity { get; set; }
    
    public Transport(string model, int capacity)
    {
        Model = model;
        Capacity = capacity;
    }
    
    public abstract void Move();
}