using DotNetLearning.WebApp.Data;
using DotNetLearning.WebApp.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace DotNetLearning.WebApp.Services
{
    public class MovieService : IMovieService
    {
        private readonly ApplicationDbContext _context;
        public MovieService(ApplicationDbContext context)
        {
                _context = context; 
        }       

        public List<Movie> GetAll() => _context.Movies.ToList();      

        public Movie GetById(int id) => _context.Movies.FirstOrDefault(m => m.Id == id);

        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void Update(Movie movie)
        {
            throw new System.NotImplementedException();
        }
    }
}
