// Загальний клас, що реалізує CRUD
public class Repository<T> :IRepository<T>
{
  public void Commit(T value1)
  {
    Console.WriteLine($"Initial commit - {value1}");
  }

  public void Commit(T value1, T value2)
  {
    if (value1.Equals(value2) != true)
    {
        Console.WriteLine($"Commit changes: {value1} => {value2}");
    }
    else
    {
        Console.WriteLine("No commit changes");
    }
  }
}
