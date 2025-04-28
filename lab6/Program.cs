using System.Text.Json;
//using BCrypt.Net;

namespace SerializeToFile
{
    /*public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string? Summary { get; set; }
    }

    public class Purchase
    {
        public string? ProductName { get; set; }

        public DateTime DateTime { get; set; }

        public decimal ProductPrice { get; set; }
    }*/

    public class Program
    {
        public static void Main(string[] args)
        {
            JsonStorage jsonStorage = new JsonStorage();
            GenericRepository usersRepository = new GenericRepository();
            usersRepository.Add(new User() { Id = 3, Name = "Sofiya", Email = "sofiya@gmail.com" });
            usersRepository.Add(new User() { Id = 4, Name = "Illya", Email = "illya@gmail.com" });

            jsonStorage.Deserialize();

            //var allUsers = usersRepository.GetAll();
            //var newUser = new User() { Id = 3, Name = "Sofiya", Email = "sofia@gmail.com" };

            //var options = new JsonSerializerOptions();
            //options.WriteIndented = true;

            //string fileName = "UsersData.json";
            //string jsonString = JsonSerializer.Serialize(allUsers, options);

            //File.WriteAllText(fileName, jsonString);

            //Console.WriteLine(File.ReadAllText("UsersData.json"));

            //List<User> deserializeUsers = JsonSerializer.Deserialize<List<User>>(File.ReadAllText("UsersData.json"));

            //Console.WriteLine(File.ReadAllText("UsersData.json"));

            /*var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            string fileName = "WeatherForecast.json";
            string jsonString = JsonSerializer.Serialize(weatherForecast);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));*/

            /*Purchase purchase = new Purchase
            {
                ProductName = "Orange juice",
                DateTime = DateTime.UtcNow,
                ProductPrice = 2.49m,
            };*/

            /*var options = new JsonSerializerOptions();

            //options.PropertyNameCaseInsensitive
            options.WriteIndented = true;

            string fileName = "ProductPurchase.json";
            string jsonString = JsonSerializer.Serialize(purchase, options);
            //byte[] jsonString = JsonSerializer.SerializeToUtf8Bytes(purchase);
            
            File.WriteAllText(fileName, jsonString);
            //File.WriteAllText("Purchase.json", jsonString);

            Console.WriteLine(File.ReadAllText(fileName));*/

            /*var purchasejson = File.ReadAllText("ProductPurchase.json");

            Purchase purchase = JsonSerializer.Deserialize<Purchase>(purchasejson);*/
        }
    }
}

/*string password = "Secret Password";
        string passwordInput = "Secret password";
        string passwordTrueHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);

        int startIndex = 7;
        int length = 16;
        string passwordSalt = passwordTrueHash.Substring(startIndex, length);

        GenericRepository myUserRepository = new GenericRepository();
        var allUsers = myUserRepository.GetAll();
        var newUser = new User() { Id = 3, Name = "Софія", Email = "sofia@gmail.com" };
        myUserRepository.Add(newUser);

        passwordInput = password;
        int i = 0;

        if (passwordSalt + passwordInput == passwordSalt + password)
        {
            Console.WriteLine("Password correct");
            Console.WriteLine("Id: " + allUsers[i].Id);
            Console.WriteLine("Name: " + allUsers[i].Name);
            Console.WriteLine("Email: " + allUsers[i].Email);
        }
        else
        {
            Console.WriteLine("Password incorrect");
        }*/