namespace Education.Persistence;

using System.Text.Json;

public class FileStorage
{
    public void WriteJson(string path, string json)
    {
        File.WriteAllText(path, json);

    }

    public string ReadJson(string path)
    {
        return File.ReadAllText(path);
    }

    public static void SaveToFile<T>(string path, List<T> data)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        File.WriteAllText(path, JsonSerializer.Serialize(data, options));
    }

    public static List<T> LoadFromFile<T>(string path)
    {
        var json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
    }



}
