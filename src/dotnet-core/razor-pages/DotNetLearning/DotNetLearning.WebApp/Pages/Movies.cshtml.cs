using DotNetLearning.WebApp.Data;
using DotNetLearning.WebApp.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace DotNetLearning.WebApp.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; }
        private ApplicationDbContext _context;
        public MoviesModel(ApplicationDbContext context)
        {
            _context = context; 
        }
        public void OnGet()
        {
            Movies = _context.Movies.ToList();
        }
    }
}
