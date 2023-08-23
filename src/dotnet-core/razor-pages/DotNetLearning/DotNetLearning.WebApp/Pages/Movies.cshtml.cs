using DotNetLearning.WebApp.Data;
using DotNetLearning.WebApp.Data.Models;
using DotNetLearning.WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace DotNetLearning.WebApp.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; }
        private IMovieService _service;
        public MoviesModel(IMovieService movieService)
        {
            _service = movieService; 
        }
        public void OnGet()
        {
            Movies = _service.GetAll();
        }
    }
}
