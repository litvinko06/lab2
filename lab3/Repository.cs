// Загальний клас, що реалізує CRUD
public class Repository<T> :IRepository<T>
{
    List<T> commitList = [];

    public void GetById(int id)
    {
        Console.WriteLine(commitList[id]);
    }

    public IEnumerable<T> GetAll()
    {
        return commitList.ToList();
    }

    public void Add(T entity)
    {
        commitList.Add(entity);
    }

    public void Update(T entity)
    {

    }

    public void Delete(T entity)
    {
        commitList.Remove(entity);
    }

    public List<T> GetCommit()
    {
        return commitList;
    }
}
