using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager.Models;

namespace MovieManager.Context
{
    public class MediaContext
    {
        public List<Movie> Movies { get; set; }
        public List<Show> Shows { get; set; }
        public List<Video> Videos { get; set; }

        public MediaContext()
        {
            Movies = new List<Movie>();
            Movies.Add(new Movie() { Id = 1, Title = "toy Story", Genre = "comedy" });
            Movies.Add(new Movie() { Id = 2, Title = "toy Story 2", Genre = "comedy" });
            Movies.Add(new Movie() { Id = 3, Title = "toy Story 3", Genre = "comedy" });
            Movies.Add(new Movie() { Id = 4, Title = "toy Story 4", Genre = "comedy" });

            Shows = new List<Show>();
            Shows.Add(new Show() { Id = 1, Title = "SpongeBob", Episode = 1, Season = 1, Writers = "bill"});
            Shows.Add(new Show() { Id = 2, Title = "River Monsters", Episode = 6, Season = 2, Writers = "bob" });
            Shows.Add(new Show() { Id = 3, Title = "The Walking Dead", Episode = 3, Season = 3, Writers = "chuck" });
            Shows.Add(new Show() { Id = 4, Title = "Game of Thrones", Episode = 4, Season = 5, Writers = "rose" });

            Videos = new List<Video>();
            Videos.Add(new Video() { Id = 1, Title = "Coding Tutorial", Format = "mp4", Length = 180, Regions = "NA" });
            Videos.Add(new Video() { Id = 2, Title = "Coding Tutorial 2", Format = "wav", Length = 20, Regions = "Eu" });
            Videos.Add(new Video() { Id = 3, Title = "Coding Tutorial 3", Format = "mp3", Length = 5, Regions = "SA" });
            Videos.Add(new Video() { Id = 4, Title = "Coding Tutorial 4", Format = "mp4", Length = 200, Regions = "Aus" });




        }
    }

}
