using System;

namespace MovieManager.Models;

public class Movie : Media
{

    public string Genre { get; set; }

    public virtual void Display()
    {
        System.Console.WriteLine($"Id: {Id}, Title: {Title}, Genre: {Genre}");
    }


}
