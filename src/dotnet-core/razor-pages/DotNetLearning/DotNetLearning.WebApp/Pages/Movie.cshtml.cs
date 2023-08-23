using DotNetLearning.WebApp.Data;
using DotNetLearning.WebApp.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace DotNetLearning.WebApp.Pages
{
    public class MovieModel : PageModel
    {
        public Movie Movie { get; set; }

        private ApplicationDbContext _context;
        public MovieModel(ApplicationDbContext context)
        {
                _context = context;
        }
        public void OnGet(int id)
        {
            Movie = _context.Movies.FirstOrDefault(m => m.Id == id);
        }
    }
}
