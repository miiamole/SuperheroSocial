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
		private List<SuperpowerModel> powers = new List<SuperpowerModel>();
		public void OnGet()
		{

		}

		public IActionResult OnPost()
		{
			SuperpowerModel power = new SuperpowerModel();

			if (Superpower1 != null)
			{
				power = new SuperpowerModel() { Superpower = Superpower1 };
			}

			if (Name != null)
			{
				new SuperheroModel() { Name = Name, SecretIdentity = SecretIdentity, SuperPower = powers, Image = "" };
			}
		}
	}
}
