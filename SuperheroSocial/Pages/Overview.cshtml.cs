using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocial.Pages
{
    public class OverviewModel : PageModel
    {
        public SuperheroModel? superhero { get; set; }
        public void OnGet(string name, string identity, string superpower)
        {

        }
    }
}
