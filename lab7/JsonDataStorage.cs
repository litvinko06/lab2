using System.Text.Json;

public class JsonDataStorage
{
    public void Serialize(List<Item> items)
    {
        var options = new JsonSerializerOptions();
        options.WriteIndented = true;
        string fileName = "StorageData.json";
        string jsonString = JsonSerializer.Serialize(items, options);
        File.WriteAllText(fileName, jsonString);
    }

    public void Deserialize()
    {
        List<Item> deserializeUsers = JsonSerializer.Deserialize<List<Item>>(File.ReadAllText("StorageData.json"));
        Console.WriteLine(File.ReadAllText("StorageData.json"));
    }
}