namespace Education.Persistence;

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


}
