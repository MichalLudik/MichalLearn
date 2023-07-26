// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

var film = new Film
{
    nazov = "Titanic",
    rok = 1997,
    cas = DateTime.UtcNow,
    HlavnyHrdina = "Leonardo Dicaprio"
};

JsonSerializer serializer = new JsonSerializer();

var dir = String.Concat(Directory.GetCurrentDirectory(), "jsonObject.txt");

using (StreamWriter sw = new StreamWriter(dir))
using (JsonWriter writer = new JsonTextWriter(sw))
{
    serializer.Serialize(writer, film);
}


Console.Read();

[Serializable]
public class Film
{
    private string Nazov;
    public string nazov
    {
        get
        {
            return Nazov;
        }
        set
        {
            Nazov = value;
        }
    }
    private int Rok;
    public int rok
    {
        get
        {
            return Rok;
        }
        set
        {
            Rok = value;
        }
    }

    private DateTime Cas;
    public DateTime cas
    {
        get
        {
            return Cas;
        }
        set
        {
            Cas = value;
        }
    }

    [NonSerialized]
    public string HlavnyHrdina;
}



