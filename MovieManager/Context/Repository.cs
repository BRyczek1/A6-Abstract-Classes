using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager.Models;

namespace MovieManager.Context
{
    public class Repository
    {
        private MediaContext mediaContext;


        public Repository(MediaContext mediaContext)
        {
            this.mediaContext = mediaContext;

        }

        public void search()
        {
            List<Media> media = new List<Media>();
            media.AddRange(mediaContext.Movies);
            media.AddRange(mediaContext.Videos);
            media.AddRange(mediaContext.Shows);

            Console.WriteLine("Which media would you like to display?");
            var userInput = Console.ReadLine();

            var result = media.FirstOrDefault(media => media.Title.Contains(userInput));
        }
    }
}
