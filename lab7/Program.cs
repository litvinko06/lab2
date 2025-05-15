//using BCrypt.Net;
using System.Diagnostics.Metrics;
using System.Text.Json;
using System.Xml.Linq;

namespace Storage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            JsonDataStorage jsonStorage = new JsonDataStorage();
            GenericStorage newGenericStorage = new GenericStorage();
            var entireStorage = newGenericStorage.GetAll();

            //newGenericStorage.Add(new Item() { Id = 3, Name = "Sofiya", Amount = 0 });
            //newGenericStorage.Add(new Item() { Id = 4, Name = "Illya", Amount = 0 });

            int choice = 1;
            int amount = 5;
            var itemById = newGenericStorage.GetById(choice);
            //itemById = new Item() { Id = itemById.Id, Name = itemById.Name, Amount = itemById.Amount - amount };
            //Console.WriteLine(itemById.Amount);

            //newGenericStorage.Update(itemById);

            //if
            switch (choice)
            {
                case 1:
                    itemById = new Item() { Id = itemById.Id, Name = itemById.Name, Amount = itemById.Amount - amount };
                    newGenericStorage.Update(itemById);
                    Console.WriteLine($"Measured value is {choice}; too low.");
                    break;

                case 2:
                    itemById = new Item() { Id = itemById.Id, Name = itemById.Name, Amount = itemById.Amount - amount };
                    newGenericStorage.Update(itemById);
                    Console.WriteLine($"Measured value is {choice}; too high.");
                    break;

                case 3:
                    itemById = new Item() { Id = itemById.Id, Name = itemById.Name, Amount = itemById.Amount - amount };
                    newGenericStorage.Update(itemById);
                    Console.WriteLine("Failed measurement.");
                    break;

                case 4:
                    itemById = new Item() { Id = itemById.Id, Name = itemById.Name, Amount = itemById.Amount - amount };
                    newGenericStorage.Update(itemById);
                    Console.WriteLine("Failed measurement.");
                    break;

                default:
                    Console.WriteLine($"Measured value is {choice}.");
                    break;
            }

            jsonStorage.Serialize(entireStorage);
            jsonStorage.Deserialize();
        }
    }
}