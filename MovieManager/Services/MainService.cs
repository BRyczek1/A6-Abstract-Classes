using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using MovieManager.Context;
using MovieManager.Dao.Interfaces;
using MovieManager.Helpers;
using MovieManager.Models;
using Spectre.Console;

namespace MovieManager.Services;

public class MainService : IMainService
{
    private readonly IRepository _repository;

    public MainService(IRepository repository)
    {
        _repository = repository;
    }

    public void Invoke()
    {
        MediaContext context = new MediaContext();
        Repository repo = new Repository(context);
        

        //Wrapper wrapper (hold onto context)
        //    wrapper => ExecutionEngineException methonds to Search

        repo.search();

       
        
        if(userInput == "movie")
        {
            Movie.display();
        }
        else if(UserInput == "show")
        {
            Show.display();
        }
        if (userInput == "video")
        {
            Video.display();
        }



    }
}
