public class GenericRepository : IDataStorage<User>
{
    private List<User> users = new List<User> // Додати пароль
    {
        new User { Id = 1, Name = "Карина", Email = "litvinko.foox@gmail.com" },
        new User { Id = 2, Name = "Олексій", Email = "kyselov.oleksii@lll.kpi.ua" }
    };

    // Подія, яка сповіщає про зміни
    public event SaveEventHandler SaveChanged;

    public List<User> GetAll() => users;
    public User GetById(int id) => users.FirstOrDefault(u => u.Id == id);

    public void Add(User user)
    {
        user.Id = users.Count + 1;
        users.Add(user);
        Save(user, "Додано");
    }

    public void Update(User user)
    {
        var existingUser = users.FirstOrDefault(u => u.Id == user.Id);
        if (existingUser != null)
        {
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            Save(user, "Оновлено");
        }
    }

    public void Delete(int id)
    {
        var user = users.FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            users.Remove(user);
            Save(user, "Видалено");
        }
    }

    public void Save(User user, string action)
    {
        SaveChanged?.Invoke(this, new SaveEventArgs { User = user, Action = action });
    }

    // Метод для виклику події
    /*protected virtual void OnUserChanged(User user, string action)
    {
        UserChanged?.Invoke(this, new UserEventArgs { User = user, Action = action });
    }*/
}