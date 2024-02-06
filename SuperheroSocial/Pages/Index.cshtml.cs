using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocial.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public string? Name { get; set; }
        public string? SecretIdentity { get; set; }
        public string? Superpower1 { get; set; }
        public string? Superpower2 { get; set; }
        public string? Superpower3 { get; set; }
        public string? Image { get; set; }
        public string Id { get; set; }
        private List<SuperpowerModel> powers = new List<SuperpowerModel>();
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            List<SuperpowerModel> powers = new List<SuperpowerModel>();
            SuperpowerModel power = new SuperpowerModel();
            Random random = new Random();
            int picIndex = random.Next(SuperheroManager.images.Count());

            if (Id != null)
            {
                int id = int.Parse(Id);
                return RedirectToPage("/Change", new { id });
            }


            if (Superpower1 != null)
            {
                power = new SuperpowerModel() { Superpower = Superpower1 };
                powers.Add(power);
            }
            if (Superpower2 != null)
            {
                power = new SuperpowerModel() { Superpower = Superpower2 };
                powers.Add(power);
            }
            if (Superpower3 != null)
            {
                power = new SuperpowerModel() { Superpower = Superpower3 };
                powers.Add(power);
            }

            if (Name != null)
            {
                SuperheroModel newHero = new SuperheroModel() { Name = Name, SecretIdentity = SecretIdentity, SuperPower = powers, Image = SuperheroManager.images[picIndex] };

                SuperheroManager.heroes.Add(newHero);

                return RedirectToPage("/Overview", new { newHero });
            }

            return Page();


        }
    }
}