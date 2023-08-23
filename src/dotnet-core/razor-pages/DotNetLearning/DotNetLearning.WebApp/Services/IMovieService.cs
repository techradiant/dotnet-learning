using DotNetLearning.WebApp.Data.Models;
using System.Collections.Generic;

namespace DotNetLearning.WebApp.Services
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        Movie GetById(int id);
        void Add(Movie movie);
        void Update(Movie movie);

    }
}
