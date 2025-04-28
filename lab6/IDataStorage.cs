//базовий інтерфейс зберігання даних

interface IDataStorage<T> //where T : BaseEntity
{
    void Add(T entity);

    void Update(T entity);

    void Delete(int id);

    T? GetById(int id);

    List<T> GetAll();

    void Save(T entity, string status);
}