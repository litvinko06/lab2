public class Program
{
    static GenericStorage storage = new GenericStorage();
    static JsonDataStorage jsonStorage = new JsonDataStorage();

    public static void Main(string[] args)
    {
        storage.SaveChanged += (sender, eventArgs) =>
        {
            Console.WriteLine($"Item '{eventArgs.Item.Name}' {eventArgs.Action}. " +
                $"New amount: {eventArgs.Item.Amount}");
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== СКЛАД ===");
            foreach (var item in storage.GetAll())
            {
                Console.WriteLine($"{item.Id}. {item.Name} — {item.Amount} од.");
            }

            Console.WriteLine("\nОберіть дію:");
            Console.WriteLine("1. Замовити товар");
            Console.WriteLine("2. Додати новий товар");
            Console.WriteLine("3. Вийти");

            Console.Write("Ваш вибір: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ProcessOrder();
                    break;
                case "2":
                    AddNewItem();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Невірний вибір.");
                    break;
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для продовження...");
            Console.ReadKey();
        }
    }

    static void ProcessOrder()
    {
        Console.Write("Введіть ID товару: ");
        if (!int.TryParse(Console.ReadLine(), out int id)) return;

        var item = storage.GetById(id);
        if (item == null)
        {
            Console.WriteLine("Товар не знайдено.");
            return;
        }

        Console.Write($"Скільки одиниць {item.Name} ви хочете замовити? ");
        if (!int.TryParse(Console.ReadLine(), out int amount)) return;

        if (item.Amount < amount)
        {
            Console.WriteLine("Недостатньо товару на складі!");
            return;
        }

        item.Amount -= amount;
        storage.Update(item);
        jsonStorage.Serialize(storage.GetAll());
        Console.WriteLine("Замовлення оформлено.");
    }

    static void AddNewItem()
    {
        Console.Write("Назва нового товару: ");
        string name = Console.ReadLine();

        Console.Write("Кількість: ");
        if (!int.TryParse(Console.ReadLine(), out int amount)) return;

        storage.Add(new Item { Name = name, Amount = amount });
        jsonStorage.Serialize(storage.GetAll());
    }
}