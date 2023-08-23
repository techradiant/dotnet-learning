using DotNetLearning.WebApp.Data;
using DotNetLearning.WebApp.Data.Models;
using DotNetLearning.WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace DotNetLearning.WebApp.Pages
{
    public class MovieModel : PageModel
    {
        public Movie Movie { get; set; }

        private IMovieService _service;
        public MovieModel(IMovieService movieService)
        {
               _service = movieService; 
        }
        public void OnGet(int id)
        {
            Movie = _service.GetById(id);
        }
    }
}
