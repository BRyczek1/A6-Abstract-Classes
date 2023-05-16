namespace MovieManager.Models;

public class Show : Media
{

    public int Season { get; set; }
    public int Episode { get; set; }
    public string Writers { get; set; }

    public virtual void Display()
    {
        System.Console.WriteLine($"Id: {Id}, Title: {Title}, Season: {Season}, Episode: {Episode}, Writers: {Writers}");
    }
}
