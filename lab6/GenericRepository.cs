using SerializeToFile;

public class GenericRepository : JsonStorage, IDataStorage<User>
{
    JsonStorage storage = new JsonStorage();

    private List<User> users = new List<User>
    {
        new User { Id = 1, Name = "Karyna", Email = "litvinko.foox@gmail.com" },
        new User { Id = 2, Name = "Oleksiy", Email = "kyselov.oleksii@lll.kpi.ua" }
    };

    // Подія, яка сповіщає про зміни
    public event SaveEventHandler SaveChanged;

    public List<User> GetAll() => users;
    public User GetById(int id) => users.FirstOrDefault(u => u.Id == id);

    public void Add(User user)
    {
        user.Id = users.Count + 1;
        users.Add(user);
        storage.Serialize(users);
        Save(user, "Added");
    }

    public void Update(User user)
    {
        var existingUser = users.FirstOrDefault(u => u.Id == user.Id);
        if (existingUser != null)
        {
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            Save(user, "Updated");
        }
    }

    public void Delete(int id)
    {
        var user = users.FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            users.Remove(user);
            Save(user, "Deleted");
        }
    }

    public void Save(User user, string action)
    {
        SaveChanged?.Invoke(this, new SaveEventArgs { User = user, Action = action });
    }
}
