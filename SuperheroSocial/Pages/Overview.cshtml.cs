using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocial.Pages
{
    public class OverviewModel : PageModel
    {
        public SuperheroModel? Hero { get; set; }
        public void OnGet(SuperheroModel hero)
        {

            Hero = hero;

        }
    }
}
