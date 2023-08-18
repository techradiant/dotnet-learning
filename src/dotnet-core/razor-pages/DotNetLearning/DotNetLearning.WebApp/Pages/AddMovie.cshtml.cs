using DotNetLearning.WebApp.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace DotNetLearning.WebApp.Pages
{
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

        public void OnGet()
        {
            //Title = "Welcome";
        }
        public IActionResult OnPost() {
            string value = $"{Title} - {Rate} - {Description}";
            //string value = $"{Movie.Title} - {Movie.Rate} - {Movie.Description}";
            if(!ModelState.IsValid)
            {
                return Page();
            }            
            return Redirect("Movies");
        }
    }
}
