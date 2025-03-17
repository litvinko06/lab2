// Загальний клас, що реалізує CRUD
public class Repository<T> :IRepository<T>
{
    List<T> commitList = [];

    public void Commit(T value1)
    {
        commitList.Add(value1);

        Console.WriteLine($"Initial commit - {value1}");
    }

    public void Commit(T value1, T value2)
    {
        if (value1.Equals(value2) != true)
        {
            commitList.Remove(value1);
            commitList.Add(value2);

            Console.WriteLine($"Commit changes: {value1} => {value2}");
        }
        else
        {
            Console.WriteLine("No commit changes");
        }
    }

    public List<T> GetCommit()
    {
        return commitList;
    }
}