// Базовий інтерфейс з методами CRUD
public interface IRepository<T>
{
  void Commit(T value1);

  void Commit(T value1, T value2);
}
