using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocial.Pages
{
    public class ChangeModel : PageModel
    {
        [BindProperty]
        //public List<SuperheroModel> heroes { get; set; }
        public int Id { get; set; }
        [BindProperty]
        public SuperheroModel Hero { get; set; }
        public IActionResult OnGet(int id)
        {
            Id = id;
            Hero = SuperheroManager.heroes.FirstOrDefault(s => s.Id == id);
            //Hej
            if (Hero == null)
            {
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }

        }


        public IActionResult OnPut(int id, SuperheroModel updatedSuperhero)
        {
            var item = SuperheroManager.heroes.FirstOrDefault(s => s.Id == id);
            if (item == null)
            {
                return Page();
            }
            else
            {
                item.Id = updatedSuperhero.Id;
                item.Name = updatedSuperhero.Name;
                item.SecretIdentity = updatedSuperhero.SecretIdentity;
                item.SuperPower = updatedSuperhero.SuperPower;

                SuperheroManager.heroes.Add(updatedSuperhero);

                return RedirectToPage("/index");
            }

        }
    }
}
