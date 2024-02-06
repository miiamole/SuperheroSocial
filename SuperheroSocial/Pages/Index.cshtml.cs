using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocial.Pages
{

	public class IndexModel : PageModel
	{
		public string? Name { get; set; }
		public string? SecretIdentity { get; set; }
		public string? Superpower1 { get; set; }
		public string? Superpower2 { get; set; }
		public string? Superpower3 { get; set; }
		public string? Image { get; set; }

		public string id { get; set; }
		private List<SuperpowerModel> powers = new List<SuperpowerModel>();
		public void OnGet()
		{


		}


	}

	public IActionResult OnPost()
	{
		List<SuperpowerModel> powers = new List<SuperpowerModel>();
		SuperpowerModel power = new SuperpowerModel();

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
			SuperheroModel newHero = new SuperheroModel() { Name = Name, SecretIdentity = SecretIdentity, SuperPower = powers, Image = "" };

			SuperheroManager.heroes.Add(newHero);
		}

		return Page();
	}
}

}
