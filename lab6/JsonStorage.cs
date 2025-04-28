//клас зберігання даних у файл
using System.Text.Json;

public class JsonStorage
{
    public void Serialize(List<User> users)
    {
        var options = new JsonSerializerOptions();
        options.WriteIndented = true;
        string fileName = "UsersData.json";
        string jsonString = JsonSerializer.Serialize(users, options);
        File.WriteAllText(fileName, jsonString);
    }

    public void Deserialize()
    {
        List<User> deserializeUsers = JsonSerializer.Deserialize<List<User>>(File.ReadAllText("UsersData.json"));
        Console.WriteLine(File.ReadAllText("UsersData.json"));
    }
}