namespace MovieManager.Models;

public class Video : Media
{

    public string Format { get; set; }
    public int Length { get; set; }
    public string Regions { get; set; }

    public virtual void Display()
    {
        System.Console.WriteLine($"Id: {Id}, Title: {Title}, Format: {Format}, Length: {Length}, Regions: {Regions}");
    }
}
