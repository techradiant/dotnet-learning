using DotNetLearning.WebApp.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace DotNetLearning.WebApp.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; }

        public void OnGet()
        {
            Movies = new List<Movie>()
            {
                new Movie(){Id=1, Title="First Movie", Rate=10, Description="First Movie Description"},
                new Movie(){ Id=2,Title="Second Movie", Rate=10, Description="Second Movie Description"},
                new Movie(){ Id=3,Title="Third Movie", Rate=10, Description="Third Movie Description"},
                new Movie(){ Id=4,Title="Fourth Movie", Rate=10, Description="Fourth Movie Description"}
            };
        }
    }
}
