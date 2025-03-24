// Базовий інтерфейс з методами CRUD
public interface IRepository<T>
{
    void GetById(int id);

    IEnumerable<T> GetAll();

    void Add(T entity);

    void Update(T entity);

    void Delete(T entity);
}
