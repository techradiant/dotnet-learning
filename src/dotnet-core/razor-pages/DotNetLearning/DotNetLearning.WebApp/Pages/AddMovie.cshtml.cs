using DotNetLearning.WebApp.Data;
using DotNetLearning.WebApp.Data.Models;
using DotNetLearning.WebApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;

namespace DotNetLearning.WebApp.Pages
{
    //[Authorize(Roles ="Admin,Manager")]
    [Authorize(Policy ="GraduatedOnly")]
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        [Required]
        public string Title { get; set; }
        [BindProperty]
        public int Rate { get; set; }
        [BindProperty]

        public string Description { get; set; }

        //[BindProperty]
        //public Movie Movie { get; set; }    

        //public void OnGetMyOnClick()
        //{
        //    string stopHeader = "";
        //}
        private IMovieService _service;
        public AddMovieModel(IMovieService movieService)
        {
            _service = movieService;
        }

        public void OnGet()
        {
            //Title = "Welcome";
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var movie = new Movie { Title = Title, Rate = Rate, Description = Description };
            _service.Add(movie);
            return Redirect("Movies");
        }
    }
}
