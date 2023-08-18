using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetLearning.WebApp.Pages
{
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public int Rate { get; set; }
        [BindProperty]
        public string Description { get; set; }

        //public void OnGetMyOnClick()
        //{
        //    string stopHeader = "";
        //}

        public void OnGet()
        {
            Title = "Welcome";
        }
        public IActionResult OnPost() {
            string value = $"{Title} - {Rate} - {Description}";
            return Page();
            //return Redirect("Movies");
        }
    }
}
