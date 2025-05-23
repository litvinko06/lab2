public class GenericStorage : IDataStorage<Item>
{
    private List<Item> items = new List<Item>
    {
        new Item { Id = 1, Name = "PCs", Amount = 10 },
        new Item { Id = 2, Name = "Headphones", Amount = 10 },
        new Item { Id = 3, Name = "Smartphones", Amount = 10 },
        new Item { Id = 4, Name = "Gamepads", Amount = 10 }
    };

    public event SaveEventHandler SaveChanged;
    public List<Item> GetAll() => items;
    public Item GetById(int id) => items.FirstOrDefault(u => u.Id == id);

    public void Add(Item item)
    {
        item.Id = items.Count + 1;
        items.Add(item);
        Save(item, "Added");
    }

    public void Update(Item item)
    {
        var existingUser = items.FirstOrDefault(u => u.Id == item.Id);
        if (existingUser != null)
        {
            existingUser.Name = item.Name;
            existingUser.Amount = item.Amount;
            Save(item, "Updated");
        }
    }

    public void Delete(int id)
    {
        var item = items.FirstOrDefault(u => u.Id == id);
        if (item != null)
        {
            items.Remove(item);
            Save(item, "Deleted");
        }
    }

    public void Save(Item item, string action)
    {
        SaveChanged?.Invoke(this, new SaveEventArgs { Item = item, Action = action });
    }
}