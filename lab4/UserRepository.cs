public class UserRepository : IRepository<User>
{
    private List<User> users = new List<User>
    {
        new User { Id = 1, Name = "Карина", Email = "litvinko.foox@gmail.com" },
        new User { Id = 2, Name = "Олексій", Email = "kyselov.oleksii@lll.kpi.ua" }
    };

    // Подія, яка сповіщає про зміни
    public event UserChangedEventHandler UserChanged;

    public List<User> GetAll() => users;
    public User GetById(int id) => users.FirstOrDefault(u => u.Id == id);

    public void Add(User user)
    {
        user.Id = users.Count + 1;
        users.Add(user);
        OnUserChanged(user, "Додано");
    }

    public void Update(User user)
    {
        var existingUser = users.FirstOrDefault(u => u.Id == user.Id);
        if (existingUser != null)
        {
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            OnUserChanged(user, "Оновлено");
        }
    }

    public void Delete(int id)
    {
        var user = users.FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            users.Remove(user);
            OnUserChanged(user, "Видалено");
        }
    }

    // Метод для виклику події
    protected virtual void OnUserChanged(User user, string action)
    {
        UserChanged?.Invoke(this, new UserEventArgs { User = user, Action = action });
    }
}