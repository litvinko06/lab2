using System.Text.Json;
//using BCrypt.Net;

namespace SerializeToFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            JsonStorage jsonStorage = new JsonStorage();
            GenericRepository usersRepository = new GenericRepository();
            usersRepository.Add(new User() { Id = 3, Name = "Sofiya", Email = "sofiya@gmail.com" });
            usersRepository.Add(new User() { Id = 4, Name = "Illya", Email = "illya@gmail.com" });

            jsonStorage.Deserialize();
        }
    }
}
