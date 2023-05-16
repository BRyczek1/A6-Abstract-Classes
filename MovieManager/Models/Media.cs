namespace MovieManager.Models;

public abstract class Media
{
    public int Id { get; set; }
    public string Title { get; set; }

    public virtual void display()
    {
        System.Console.WriteLine($"Id: {Id}, Title: {Title}");
    }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}";
    }

}
