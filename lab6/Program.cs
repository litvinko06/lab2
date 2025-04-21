using BCrypt.Net;
using System.Text.Json;

namespace SerializeBasic
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string? Summary { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
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

            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);

            Console.WriteLine(jsonString);
        }
    }
}